using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.View.Assortiment.drinks;

namespace WindowsFormsApp1
{
    public partial class drinks : Form, IdrinkView
    {

        public event EventHandler LoadAssortimentForm;
        public drinks()
        {
            InitializeComponent();
        }

        public IList<string> DrinkList
        {
            get { return (IList<string>)this.DelishBox.DataSource; }
            set { this.DelishBox.DataSource = value; }
        }

        public int SelectedDrink
        {
            get { return this.DelishBox.SelectedIndex; }
            set { this.DelishBox.SelectedIndex = value; }
        }
        new public string Name
        {
            get { return this.NameBox.Text; }
            set { this.NameBox.Text = value; }
        }
        public string Group
        {
            get { return this.GroupBox.Text; }
            set { this.GroupBox.Text = value; }
        }
        public string Price
        {
            get { return this.PriceBox.Text; }
            set { this.PriceBox.Text = value; }
        }
        public string Exit
        {
            get { return this.ExitBox.Text; }
            set { this.ExitBox.Text = value; }
        }
        public string Description
        {
            get { return this.DescriptionBox.Text; }
            set { this.DescriptionBox.Text = value; }
        }
        public Presenter.delish.DrinkPresent Presenter { get; set; }
        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void drinks_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadAssortimentForm?.Invoke(this, EventArgs.Empty);
        }

        private void DelishBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Presenter.UpdateDelishView(DelishBox.SelectedIndex);
        }
    }
}
