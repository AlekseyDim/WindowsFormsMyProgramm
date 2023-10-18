using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsGoods
{
    public partial class Form2 : Form
    {
        public UnitOfGoods Unit { get; set; }
        private bool _nameError = true;
        private bool _countryError = true;
        private bool _priceError = true;


        public Form2()
        {
            InitializeComponent();
            TestButton();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            int.TryParse(PriceTextBox.Text, out var price);
            Unit = new UnitOfGoods()
            {
                Name  = NameTextBox.Text,
                Country = СountryTextBox.Text,
                Price = price
            };
            this.Close();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if(NameTextBox.Text.Count() < 4)
            {
                NameTextBox.BackColor = Color.IndianRed;
                _nameError = true;
             }
            else
            {
                NameTextBox.BackColor = Color.White;
                _nameError = false;

            }
            TestButton();
        }
        private void TestButton()
        {
            if(_nameError == false & _countryError == false & _priceError == false)
            {
                ApplyButton.Enabled = true;
            }
            else
            {
                ApplyButton.Enabled = false;
            }
        }

        private void СountryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (СountryTextBox.Text.Count() < 4)
            {
                СountryTextBox.BackColor = Color.IndianRed;
                _countryError = true;
            }
            else
            {
                СountryTextBox.BackColor = Color.White;
                _countryError = false;

            }
            TestButton();
        }

        private void PriceTextBox_TextChanged(object sender, EventArgs e)
        {
            if (PriceTextBox.Text.Count() < 1)
            {
                PriceTextBox.BackColor = Color.IndianRed;
                _priceError = true;
            }
            else
            {
                if(!int.TryParse(PriceTextBox.Text, out var price))
                {
                    _priceError = true;

                }
                else
                {
                    PriceTextBox.BackColor = Color.White;
                    _priceError = false;

                }
            }
            TestButton();
        }
    }
}
