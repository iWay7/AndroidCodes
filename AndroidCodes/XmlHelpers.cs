using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AndroidCodes
{
    public static class XmlHelpers
    {

        public static void TraversalXmlForImports(XmlNode xmlNode, List<string> imports)
        {
            string import = CodeHelper.MakeImport(xmlNode);
            if (import != null && imports.Contains(import) == false)
            {
                imports.Add(import);
            }
            foreach (XmlNode childNode in xmlNode.ChildNodes)
            {
                TraversalXmlForImports(childNode, imports);
            }
        }

        public static void TraversalXmlForValues(XmlNode xmlNode, List<string> values, CodeType codeType)
        {
            string value = CodeHelper.MakeValue(xmlNode, codeType);
            if (value != null && values.Contains(value) == false)
            {
                values.Add(value);
            }
            foreach (XmlNode childNode in xmlNode.ChildNodes)
            {
                TraversalXmlForValues(childNode, values, codeType);
            }
        }

        public static void TraversalXmlForFindViews(XmlNode xmlNode, List<string> findViews, CodeType codeType)
        {
            string findView = CodeHelper.MakeFindView(xmlNode, codeType);
            if (findView != null && findViews.Contains(findView) == false)
            {
                findViews.Add(findView);
            }
            foreach (XmlNode childNode in xmlNode.ChildNodes)
            {
                TraversalXmlForFindViews(childNode, findViews, codeType);
            }
        }

        public static void TraversalXmlForSetViews(XmlNode xmlNode, List<string> setViews, CodeType codeType)
        {
            List<string> setView = CodeHelper.MakeSetView(xmlNode, codeType);
            if (setView != null)
            {
                setViews.AddRange(setView);
            }
            foreach (XmlNode childNode in xmlNode.ChildNodes)
            {
                TraversalXmlForSetViews(childNode, setViews, codeType);
            }
        }
    }
}
