using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Presenter;
using WindowsFormsApp1.View.Product;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form, IProductView
    {
        public event EventHandler LoadMainForm;
        private bool _isEditMode = false;
        public Form3()
        {
            InitializeComponent();
        }



        public IList<string> ProductList
        {
            get { return (IList<string>)this.ProductListBox.DataSource; }
            set { this.ProductListBox.DataSource = value; }
        }

        public int SelectedProduct
        {
            get { return this.ProductListBox.SelectedIndex; }
            set { this.ProductListBox.SelectedIndex = value; }
        }
        new public string Name
        {
            get { return this.NameBox.Text; }
            set { this.NameBox.Text = value; }
        }
        public string Unit
        {
            get { return this.UnitBox.Text; }
            set { this.UnitBox.Text = value; }
        }
        public string Overprice
        {
            get { return this.OverpriceBox.Text; }
            set { this.OverpriceBox.Text = value; }
        }
        public string Remains
        {
            get { return this.RemainsBox.Text; }
            set { this.RemainsBox.Text = value; }
        }
        public Provide Provide
        {
            get
            {
                return new Provide(
                    name: this.ProvideBox.Text
                );
            }
            set
            {
                this.ProvideBox.Text = value?.Name ?? string.Empty;
            }
        }

        public Presenter.ProductPresenter Presenter { get; set; }


        private void button1_Click(object sender, EventArgs e)
        {
            LoadMainForm?.Invoke(this, EventArgs.Empty);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            addProduct addProduct = new addProduct(Presenter);
            addProduct.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Presenter.DeleteProduct();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Presenter.UpdateProductView(ProductListBox.SelectedIndex);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
