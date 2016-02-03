using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace AndroidCodes
{
    public static class CodeHelper
    {
        private static string MakeAndroidId(XmlNode xmlNode)
        {
            if (xmlNode.Attributes == null)
            {
                return null;
            }

            XmlAttribute xmlAttribute = xmlNode.Attributes["android:id"];
            if (xmlAttribute == null)
            {
                return null;
            }

            return xmlAttribute.Value;
        }

        private static string MakeResRef(string androidId)
        {
            string idToRDotId = androidId;
            int splitIndex = idToRDotId.IndexOf('/');
            if (splitIndex >= 0)
            {
                idToRDotId = idToRDotId.Substring(splitIndex + 1);
            }
            return "R.id." + idToRDotId;
        }

        private static string MakeValueNamePrefix(CodeType codeType)
        {
            if (codeType == CodeType.Adapter)
                return "";
            return "private";
        }

        private static string MakeValueName(string androidId, CodeType codeType)
        {
            string idToValueName = androidId;
            int splitIndex = idToValueName.IndexOf('/');
            if (splitIndex >= 0)
            {
                idToValueName = idToValueName.Substring(splitIndex + 1);
            }
            idToValueName = NameHelper.Replace_xWithX(idToValueName);
            switch (codeType)
            {
                case CodeType.Activity:
                case CodeType.Fragment:
                    idToValueName = "m" + NameHelper.DaTuoFeng(idToValueName);
                    break;
                case CodeType.Adapter:
                    idToValueName = NameHelper.XiaoTuoFeng(idToValueName);
                    break;
            }
            return idToValueName;
        }

        public static string MakeImport(XmlNode xmlNode)
        {
            string androidId = MakeAndroidId(xmlNode);
            if (androidId == null)
            {
                return null;
            }

            if (xmlNode.Name.Equals("merge"))
            {
                return null;
            }
            else if (xmlNode.Name.Equals("include"))
            {
                return null;
            }
            else if (xmlNode.Name.Equals("fragment"))
            {
                XmlAttribute fragmentName = xmlNode.Attributes["android:name"];
                if(fragmentName == null)
                {
                    return null;
                }
                return "import " + fragmentName.Value + ";";
            }
            else if(xmlNode.Name.Contains('.'))
            {
                return "import " + xmlNode.Name + ";";
            }
            else if (xmlNode.Name.Equals("View"))
            {
                return "import android.view.View;";
            }
            else
            {
                return "import android.widget." + xmlNode.Name + ";";
            }
        }

        public static string MakeValue(XmlNode xmlNode, CodeType codeType)
        {
            string androidId = MakeAndroidId(xmlNode);
            if (androidId == null) return null;

            string valueNamePrefix = MakeValueNamePrefix(codeType);
            string valueName = MakeValueName(androidId, codeType);

            if (xmlNode.Name.Equals("merge"))
            {
                return null;
            }
            else if (xmlNode.Name.Equals("include"))
            {
                return valueNamePrefix + " View " + valueName + ";";
            }
            else if (xmlNode.Name.Equals("fragment"))
            {
                XmlAttribute fragmentName = xmlNode.Attributes["android:name"];
                if (fragmentName == null)
                {
                    return null;
                }
                string className = NameHelper.SimpleClassName(fragmentName.Value);
                return valueNamePrefix + " " + className + " " + valueName + ";";
            }
            else
            {
                string className = NameHelper.SimpleClassName(xmlNode.Name);
                return valueNamePrefix + " " + className + " " + valueName + ";";
            }
        }

        public static string MakeFindView(XmlNode xmlNode, CodeType codeType)
        {
            string androidId = MakeAndroidId(xmlNode);
            if (androidId == null) return null;

            string idToRDotId = MakeResRef(androidId);
            string idToValueName = MakeValueName(androidId, codeType);
            
            if (xmlNode.Name.Equals("merge"))
            {
                return null;
            }
            else if (xmlNode.Name.Equals("include"))
            {
                switch (codeType)
                {
                    case CodeType.Activity:
                        return idToValueName + " = findViewById(" + idToRDotId + ");";
                    case CodeType.Fragment:
                        return idToValueName + " = mRootView.findViewById(" + idToRDotId + ");";
                    case CodeType.Adapter:
                        return "View " + idToValueName + " = convertView.findViewById(" + idToRDotId + ");";
                }
            }
            else if (xmlNode.Name.Equals("fragment"))
            {
                if(codeType == CodeType.Adapter)
                {
                    return null;
                }
                XmlAttribute fragmentName = xmlNode.Attributes["android:name"];
                if (fragmentName == null)
                {
                    return null;
                }
                string className = NameHelper.SimpleClassName(fragmentName.Value);
                return idToValueName + " = (" + className + ") mFragmentManager.findFragmentById(" + idToRDotId + ");";
            }
            else if (xmlNode.Name.Contains('.'))
            {
                string className = NameHelper.SimpleClassName(xmlNode.Name);
                switch (codeType)
                {
                    case CodeType.Activity:
                        return idToValueName + " = (" + className + ") findViewById(" + idToRDotId + ");";
                    case CodeType.Fragment:
                        return idToValueName + " = (" + className + ") mRootView.findViewById(" + idToRDotId + ");";
                    case CodeType.Adapter:
                        return className + " " + idToValueName + " = (" + className + ") convertView.findViewById(" + idToRDotId + ");";
                }
            }
            else if (xmlNode.Name.Equals("View"))
            {
                switch (codeType)
                {
                    case CodeType.Activity:
                        return idToValueName + " = findViewById(" + idToRDotId + ");";
                    case CodeType.Fragment:
                        return idToValueName + " = mRootView.findViewById(" + idToRDotId + ");";
                    case CodeType.Adapter:
                        return "View " + idToValueName + " = convertView.findViewById(" + idToRDotId + ");";
                }
            }
            else
            {
                switch (codeType)
                {
                    case CodeType.Activity:
                        return idToValueName + " = (" + xmlNode.Name + ") findViewById(" + idToRDotId + ");";
                    case CodeType.Fragment:
                        return idToValueName + " = (" + xmlNode.Name + ") mRootView.findViewById(" + idToRDotId + ");";
                    case CodeType.Adapter:
                        return xmlNode.Name + " " + idToValueName + " = (" + xmlNode.Name + ") convertView.findViewById(" + idToRDotId + ");";
                }
            }
            return null;
        }

        public static List<string> MakeSetView(XmlNode xmlNode, CodeType codeType)
        {
            string androidId = MakeAndroidId(xmlNode);
            if (androidId == null) return null;
           
            string valueName = MakeValueName(androidId, codeType);
         
            List<string> lines = new List<string>();
            if(xmlNode.Name != null && xmlNode.Name.EndsWith("TextView"))
            {

                XmlAttribute xmlAttribute = xmlNode.Attributes["tools:text"];
                if (xmlAttribute != null)
                {
                    lines.Add(valueName + ".setText(\"" + xmlAttribute.Value + "\");");
                }
            }

            return lines;
        }
    }
}
