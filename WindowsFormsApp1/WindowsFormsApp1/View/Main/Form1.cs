using System;
using System.Windows.Forms;
using WindowsFormsApp1.View.Main;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form, IMainView
    {
        public event EventHandler LoadProvideForm;
        public event EventHandler LoadProductForm;
        public event EventHandler LoadAssortimentForm;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadAssortimentForm?.Invoke(this, EventArgs.Empty);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadProductForm?.Invoke(this, EventArgs.Empty);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadProvideForm?.Invoke(this, EventArgs.Empty);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
