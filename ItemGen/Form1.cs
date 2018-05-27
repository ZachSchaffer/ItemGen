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

namespace ItemGen
{
    public partial class Form1 : Form
    {
        public Item item;

        public Form1()
        {
            InitializeComponent();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(item.Name))
            {
                MessageBox.Show("You must create an item first!");
            }

            else
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog()
                {
                    Filter = "item Files (*.itm)|*.itm|All Files (*.*)|*.*"
                };
                string strShowFileName = string.Empty;
                string[] strFile = item.FileName.Split(Path.DirectorySeparatorChar);
                strShowFileName = strFile[strFile.Length - 1];

                if (string.IsNullOrEmpty(strShowFileName))
                    strShowFileName = item.Name;

                saveFileDialog.FileName = strShowFileName;

                if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    item.FileName = saveFileDialog.FileName;
                    item.Save();
                }
            }
        }


        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSelectItemType formSelectItem = new FormSelectItemType();
            formSelectItem.ShowDialog();
            if (formSelectItem.DialogResult == DialogResult.OK)
            {
                item = formSelectItem.ReturnItem;
            }
            formSelectItem.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
