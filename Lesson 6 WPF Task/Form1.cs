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

namespace Lesson_6_WPF_Task
{
    public partial class Form1 : Form
    {
        public string FileName { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Open_Btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "All Files(*.*)|*.*|Text Files(*.txt)|*.txt||";
            open.FilterIndex = 1;

            if (open.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = new StreamReader(open.FileName))
                {
                    richTextBox1.Text = reader.ReadToEnd();
                }
            }
        }

        private void Save_Btn_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(save.FileName))
                {
                    writer.Write(richTextBox1.Text);
                }
            }
        }

        private void Choose_File_Btn_Click(object sender, EventArgs e)
        {
            //OpenFileDialog open = new OpenFileDialog();
            //open.Filter = "All Files(*.*)|*.*|Png Files(*.png)|*.png||";
            //open.FilterIndex = 1;

            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "All Files(*.*)|*.*|Png Files(*.png)|*.png||";
                dlg.FilterIndex = 1;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    ovalPictureBox1.Image = new Bitmap(dlg.FileName);
                }
            }
        }
    }
}
