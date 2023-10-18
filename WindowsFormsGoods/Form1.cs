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
    public partial class Form1 : Form
    {   
        private Form2 _form;
        public List<UnitOfGoods> Goods { get; set; }
        public Form1()
        {
            InitializeComponent();
            Goods = new List<UnitOfGoods>();
            DeleteButton.Enabled = false;
            ClearButton.Enabled = false;
            EditButton.Enabled = false;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _form = new Form2();
            _form.ShowDialog();
            ///if (_form.Unit != null) Goods.Add(_form.Unit);
            //GoodsListBox.Items.Clear();
            //foreach(var item in Goods)
            //{
            //    GoodsListBox.Items.Add($"Название: {item.Name} Страна: {item.Country} Цена: {item.Price}");
            //}
            if (_form.Unit != null)
            {
                Goods.Add(_form.Unit);
                GoodsListBox.Items.Add($"Название: {_form.Unit.Name} Страна: {_form.Unit.Country} Цена: {_form.Unit.Price}");
            }
            //GoodsListBox.Items.Add(_form.Unit);

            if(GoodsListBox.Items.Count > 0)
            {
                DeleteButton.Enabled = true;
                ClearButton.Enabled = true;
                EditButton.Enabled = true;
            }

        }

        private void EditButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if(GoodsListBox.SelectedIndex != -1)
            {
                Goods.RemoveAt(GoodsListBox.SelectedIndex);
                GoodsListBox.Items.RemoveAt(GoodsListBox.SelectedIndex);
            }
            MessageBox.Show($"Количество товаров в списке: {Goods.Count()}");
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            if(GoodsListBox.Items != null)
            {
                GoodsListBox.Items.Clear();
                Goods.Clear();
            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
