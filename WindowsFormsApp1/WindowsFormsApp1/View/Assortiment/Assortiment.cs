using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Presenter;
using WindowsFormsApp1.Presenter.delish;
using WindowsFormsApp1.View.Assortiment;

namespace WindowsFormsApp1
{
    public partial class Assortiment : Form, IAssortimentView
    {

        public event EventHandler LoadMainForm;
        public event EventHandler LoadSaladsForm;
        public event EventHandler LoadFirst_CoursesForm;
        public event EventHandler LoadSecond_CoursesForm;
        public event EventHandler LoadDesertsForm;
        public event EventHandler LoadDrinksForm;
        public event EventHandler LoadBakeryForm;

        


        public Assortiment()
        {
            InitializeComponent();
        }

        public Presenter.AssortimentPresent Presenter { get; set; }


        private void button1_Click(object sender, EventArgs e)
        {
            LoadMainForm?.Invoke(this, EventArgs.Empty);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadFirst_CoursesForm?.Invoke(this, EventArgs.Empty);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadSecond_CoursesForm?.Invoke(this, EventArgs.Empty);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadDesertsForm?.Invoke(this, EventArgs.Empty);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoadDrinksForm?.Invoke(this, EventArgs.Empty);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LoadBakeryForm?.Invoke(this, EventArgs.Empty);
        }

 

        private void button9_Click(object sender, EventArgs e)
        {
           LoadSaladsForm?.Invoke(this, EventArgs.Empty);
        }

     

        private void Assortiment_Load(object sender, EventArgs e)
        {

        }
    }
}
