using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.View.Product;
using WindowsFormsApp1.Presenter;

namespace WindowsFormsApp1
{
    public partial class addProduct: Form, IAdderProductView
    {
        public addProduct(ProductPresenter Presenter)
        {
            InitializeComponent();
            presenter = Presenter;
            List<Provide> Provides = new List<Provide>
            {
                 new Provide("ООО 'Первый поставщик'", "ул. Центральная, 1", "Иванов И.И.", "123-45-67", "Сбербанк", "1234567890", "7701234567"),
                 new Provide("ЗАО 'Второй поставщик'", "просп. Мира, 10", "Петров П.П.", "987-65-43", "ВТБ", "0987654321", "7702345678"),
                 new Provide("ООО 'Третий поставщик'", "ул. Советская, 15", "Сидоров С.С.", "555-12-34", "Альфа-Банк", "5432109876", "7703456789"),
                 new Provide("ИП 'Четвертый поставщик'", "ул. Ленина, 20", "Кузнецов К.К.", "111-22-33", "Тинькофф", "6789012345", "7704567890"),
                 new Provide("ООО 'Пятый поставщик'", "ул. Гагарина, 5", "Смирнова А.А.", "444-55-66", "Райффайзенбанк", "2468013579", "7705678901"),
                 new Provide("ЗАО 'Шестой поставщик'", "ул. Пушкина, 12", "Попов В.В.", "777-88-99", "Газпромбанк", "9182736450", "7706789012")
            };

            ProvideBox.DataSource = Provides;
            ProvideBox.DisplayMember = "Name";
        }

        public Provide Provide
        {
            get { return (Provide)this.ProvideBox.SelectedItem; }
            set { this.ProvideBox.SelectedItem = value; }
        }


        public string NameProduct
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
            get { return this.OverPriceBox.Text; }
            set { this.OverPriceBox.Text = value; }
        }
        public string Remains
        {
            get { return this.RemainsBox.Text; }
            set { this.RemainsBox.Text = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameBox.Text))
            {
                MessageBox.Show("Введите название продукта.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(UnitBox.Text))
            {
                MessageBox.Show("Введите единицы измерения товара.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!decimal.TryParse(OverPriceBox.Text, out decimal parsedOverPrice))
            {
                MessageBox.Show("Введите корректную надбавку(число).", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!decimal.TryParse(RemainsBox.Text, out decimal parsedRemains) || parsedRemains <= 0)
            {
                MessageBox.Show("Введите корректный положительный остаток.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ProvideBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите клиента из списка.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            presenter.SetAdderProductView(this);
            presenter.AddProduct();

        }
        public Presenter.ProductPresenter presenter { private get; set; }

     
        private void addProduct_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ProvideBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Provide selectedProvide = (Provide)ProvideBox.SelectedItem;
        }
    }
}
