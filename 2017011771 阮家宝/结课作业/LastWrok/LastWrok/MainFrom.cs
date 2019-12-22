using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LastWrok
{
    public partial class MainFrom : Form
    {
        public MainFrom()
        {
            InitializeComponent();
            searchedFiles = new List<string>();
            searchComplete += new refreshListBoxHanlder(updateListBox);
        }

        private void btOpen_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                txDir.Text = fd.SelectedPath;
            }
            Thread thread = new Thread(new ParameterizedThreadStart(searchFilesinFolder));
            thread.Start(this);
        }
        public static void searchFilesinFolder(object obj)
        {
            string strDir = obj.ToString();
            MainFrom thisForm = (MainFrom)obj;
            strDir = thisForm.txDir.Text;
            if (strDir != null && strDir.Length > 0)
            {
                if (Directory.Exists(strDir))
                {
                    searchedFiles.Clear();
                    List<string> allSearcheFiles = new List<string>();
                    List<string> folders2Search = new List<string>();
                    folders2Search.Add(strDir);
                    while (folders2Search.Count > 0)
                    {
                        try
                        {
                            string curFolder = folders2Search[0];
                            folders2Search.RemoveAt(0);
                            string[] files = Directory.GetFiles(curFolder);
                            string[] dirs = Directory.GetDirectories(curFolder);
                            foreach (string item in files)
                                allSearcheFiles.Add(item);
                            foreach (string item in dirs)
                                folders2Search.Add(item);
                        }
                        catch { }
                    }
                    searchedFiles.AddRange(allSearcheFiles);
                    refreshListBoxHanlder updateDelegate = new refreshListBoxHanlder(thisForm.updateListBox);
                    thisForm.Invoke(updateDelegate, thisForm);
                    thisForm.searchComplete(thisForm);
                }
            }
        }
        private void updateListBox(object sender)
        {
            if (this.InvokeRequired)
            {
                refreshListBoxHanlder delegateFunc = new refreshListBoxHanlder(updateListBox);
                this.Invoke(delegateFunc, sender);
            }
            else
            {
                lsbFiles.Items.Clear();
                lsbFiles.Items.AddRange(searchedFiles.ToArray());
            }
        }
        public delegate void refreshListBoxHanlder(object sender);
        public event refreshListBoxHanlder searchComplete;
        public static List<string> searchedFiles;

        private void txDir_TextChanged(object sender, EventArgs e)
        {

        }

        private void lsbFiles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
