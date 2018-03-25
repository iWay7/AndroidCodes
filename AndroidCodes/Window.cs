using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace AndroidCodes
{
    public partial class Window : Form
    {
        public Window()
        {
            InitializeComponent();
        }

        private void Window_Load(object sender, EventArgs e)
        {
            mSplitContainer1.SplitterDistance = (mSplitContainer1.Width - mSplitContainer1.SplitterWidth) / 2;

        }

        private void Window_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal || WindowState == FormWindowState.Maximized)
            {
                switch(mTabControl.SelectedIndex)
                {
                    case 0:
                        mSplitContainer1.SplitterDistance = (mSplitContainer1.Width - mSplitContainer1.SplitterWidth) / 2;
                        break;
                }
            }
        }

        private void mGenActivityCodeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> lines = new List<string>();
         
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.LoadXml(mTextBox1.Text);

                List<string> imports = new List<string>();
                XmlHelpers.TraversalXmlForImports(xmlDocument, imports);

                List<string> values = new List<string>();
                XmlHelpers.TraversalXmlForValues(xmlDocument, values, CodeType.Activity);

                List<string> findViews = new List<string>();
                XmlHelpers.TraversalXmlForFindViews(xmlDocument, findViews, CodeType.Activity);

                List<string> setViews = new List<string>();
                XmlHelpers.TraversalXmlForSetViews(xmlDocument, setViews, CodeType.Activity);

                lines.AddRange(imports);
                lines.Add("");
                lines.AddRange(values);
                lines.Add("");
                lines.AddRange(findViews);
                lines.Add("");
                lines.AddRange(setViews);
                lines.Add("");

                mGenActivityCodeBtn.Lines = lines.ToArray();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, ex.Message);
            }
        }

        private void mGenAdapterCodeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> lines = new List<string>();

                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.LoadXml(mTextBox1.Text);

                List<string> imports = new List<string>();
                XmlHelpers.TraversalXmlForImports(xmlDocument, imports);

                List<string> findViews = new List<string>();
                XmlHelpers.TraversalXmlForFindViews(xmlDocument, findViews, CodeType.Adapter);

                List<string> setViews = new List<string>();
                XmlHelpers.TraversalXmlForSetViews(xmlDocument, setViews, CodeType.Adapter);

                lines.AddRange(imports);
                lines.Add("");
                lines.AddRange(findViews);
                lines.Add("");
                lines.AddRange(setViews);
                lines.Add("");

                mGenActivityCodeBtn.Lines = lines.ToArray();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, ex.Message);
            }
        }

        private void mGenFragmentCodeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> lines = new List<string>();

                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.LoadXml(mTextBox1.Text);

                List<string> imports = new List<string>();
                XmlHelpers.TraversalXmlForImports(xmlDocument, imports);

                List<string> values = new List<string>();
                XmlHelpers.TraversalXmlForValues(xmlDocument, values, CodeType.Fragment);

                List<string> findViews = new List<string>();
                XmlHelpers.TraversalXmlForFindViews(xmlDocument, findViews, CodeType.Fragment);

                List<string> setViews = new List<string>();
                XmlHelpers.TraversalXmlForSetViews(xmlDocument, setViews, CodeType.Fragment);

                lines.AddRange(imports);
                lines.Add("");
                lines.AddRange(values);
                lines.Add("");
                lines.AddRange(findViews);
                lines.Add("");
                lines.AddRange(setViews);
                lines.Add("");

                mGenActivityCodeBtn.Lines = lines.ToArray();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, ex.Message);
            }
        }

        private void mTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.A)
            {
                ((TextBox)sender).SelectAll();
            }
        }

        private void mTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.A)
            {
                ((TextBox)sender).SelectAll();
            }
        }

    }
}
