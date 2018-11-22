using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notatnik_Oryginalny
{
    //public partial class Form2 : Form
    //{
    //    public Form2()
    //    {
    //        InitializeComponent();
    //    }

    //    private void button1_Click(object sender, EventArgs e)
    //    {
    //        Form1 m = new Form1();
    //        string text = m.szukanieTekstu("dupa");
    //    }
        

    //}
    public partial class Form2 : Form
    {
        Form1 parent;
        public Form2(Form1 Parentowe)
        {
            parent = Parentowe;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form1 m = new Form1();

            string text = parent.szukanieTekstu(textBox1.Text);
        }
    }
}
