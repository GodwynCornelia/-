using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsApp1.Presenter;
using WindowsFormsApp1.View.Postavshik;

namespace WindowsFormsApp1
{
    public partial class allPostavshik : Form, IProvideView
    {
        private bool _isEditMode = false;

        public event EventHandler LoadMainForm;
        public allPostavshik()
        {
            InitializeComponent();
        }

        public IList<string> ProvideList
        {
            get { return (IList<string>)this.ProvideListBox.DataSource; }
            set { this.ProvideListBox.DataSource = value; }
        }

        public int SelectedProvide
        {
            get { return this.ProvideListBox.SelectedIndex; }
            set { this.ProvideListBox.SelectedIndex = value; }
        }
        new public string Name
        {
            get { return this.NameBox.Text; }
            set { this.NameBox.Text = value; }
        }
        public string Addres
        {
            get { return this.AddresBox.Text; }
            set { this.AddresBox.Text = value; }
        }
        public string FIO
        {
            get { return this.FIOBox.Text; }
            set { this.FIOBox.Text = value; }
        }
        public string Phone
        {
            get { return this.PhoneBox.Text; }
            set { this.PhoneBox.Text = value; }
        }
        public string Bank
        {
            get { return this.BankBox.Text; }
            set { this.BankBox.Text = value; }
        }
        public string Check
        {
            get { return this.СheckBox.Text; }
            set { this.СheckBox.Text = value; }
        }
        public string INN
        {
            get { return this.INNBox.Text; }
            set { this.INNBox.Text = value; }
        }
        public ProvidePresenter Presenter
        {
            private get; set;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadMainForm?.Invoke(this, EventArgs.Empty);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Presenter.UpdateProvideView(ProvideListBox.SelectedIndex);
        }

        private void allPostavshik_Load(object sender, EventArgs e)
        {

        }
    }
}
