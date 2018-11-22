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

                int start = 0;
                start = richTextBox1.Find(szukanyTekst);

                richTextBox1.Select(start, szukanyTekst.Length);

                richTextBox1.SelectionBackColor = Color.Yellow;
                return szukanyTekst;

        }

        public string zamianaTekstu(string szukanyTekst, string zamienionyTekst)
        {

            int start = 0;
            start = richTextBox1.Find(szukanyTekst);

            richTextBox1.Select(start, szukanyTekst.Length);
            string tekst = richTextBox1.Text;
            richTextBox1.Text = richTextBox1.Text.Replace(tekst, zamienionyTekst);

            richTextBox1.SelectionBackColor = Color.Yellow;
            return zamienionyTekst;

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
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
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
            Form2 m = new Form2(this);
            m.Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void zaznaczWszystkoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void godzinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += DateTime.Now.ToString();
        }

        private void zawijanieWierszyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.WordWrap == true)
            {
                richTextBox1.WordWrap = false;
                zawijanieWierszyToolStripMenuItem1.Checked = false;
            }
            else
            {
                richTextBox1.WordWrap = true;
                zawijanieWierszyToolStripMenuItem1.Checked = true;
            }
        }

        private void czcionkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.Font = fontDialog1.Font;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox1.Text, fontDialog1.Font, Brushes.Black, e.MarginBounds, StringFormat.GenericTypographic);
        }

        private void zamieńToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 m = new Form3(this);
            m.Show();
        }
    }
}
