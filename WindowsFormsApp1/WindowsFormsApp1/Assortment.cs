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

namespace WindowsFormsApp1
{
    public partial class Assortment : Form
    {
        public Assortment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 mainWindows = new Form1();
            mainWindows.ShowDialog();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            snacks snacks = new snacks();
            snacks.ShowDialog();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            first_Сourses soup = new first_Сourses();
            soup.ShowDialog();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            second_Courses Hot = new second_Courses();
            Hot.ShowDialog();
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            deserts dessert = new deserts();
            dessert.ShowDialog();
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hide();
            drinks potable = new drinks();
            potable.ShowDialog();
            Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Hide();
            Сonfectionery confection = new Сonfectionery();
            confection.ShowDialog();
            Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Hide();
            bakery bake = new bakery();
            bake.ShowDialog();
            Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Hide();
            salads salad = new salads();
            salad.ShowDialog();
            Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Hide();
            fruits greengrocery = new fruits();
            greengrocery.ShowDialog();
            Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Hide();
            addDelish delish = new addDelish();
            delish.ShowDialog();
            Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Hide();
            deleteDelish delish = new deleteDelish();
            delish.ShowDialog();
            Close();
        }
    }
}
