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

namespace Notatnik_Oryginalny
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        public string szukanieTekstu(string szukanyTekst)
        {
            szukanyTekst = "";
            int start = richTextBox1.Find(szukanyTekst);

            richTextBox1.Select(start, szukanyTekst.Length);

            richTextBox1.SelectionBackColor = Color.Yellow;
            return szukanyTekst;
        }
        //private System.Drawing.Printing.PrintDocument docToPrint = new System.Drawing.Printing.PrintDocument();

        private void zawijanieWierszyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void zapiszJakoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName);
            }
        }



        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!File.Exists(saveFileDialog1.FileName))
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SaveFile(saveFileDialog1.FileName);
                }
            }
            else
            {
                File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
            }
        }

        private void drukujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void cofnijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void wytnijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void kopiujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void wklejToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void usuńToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{DELETE}");
            // richTextBox1.SelectedText = "";
        }

       

        private void znajdźToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 m = new Form2();
            m.Show();
            //Form2 frm2 = new Form2();
            //frm2.MyProperty = richTextBox1.Text;
            //frm2.Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

    }
}
