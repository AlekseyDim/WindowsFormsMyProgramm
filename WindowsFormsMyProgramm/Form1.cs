using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsMyProgramm
{
    public partial class Form1 : Form
    {
        private Form2 _form;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            _form = new Form2();
            _form.Show();
            
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            textBox1.Text = _form?.TText;
            //if(_form != null) textBox1.Text = _form.TText;
        }
    }
}
