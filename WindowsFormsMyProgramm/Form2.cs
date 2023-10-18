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
    public partial class Form2 : Form
    {
        public string TText{ get; set; }

        public Form2()
        {
            InitializeComponent();
            //textBox1.Text = s;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TText = (sender as TextBox).Text;//textBox1.Text - то же самое
        }
    }
}
