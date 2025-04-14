using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.View.Assortiment;
using WindowsFormsApp1.View.Postavshik;
using WindowsFormsApp1.View.Assortiment.bakery;
using WindowsFormsApp1.View.Assortiment.deserts;
using WindowsFormsApp1.View.Assortiment.drinks;
using WindowsFormsApp1.View.Assortiment.first_Courses;
using WindowsFormsApp1.View.Assortiment.salads;
using WindowsFormsApp1.View.Assortiment.second_Courses;

namespace WindowsFormsApp1.Presenter
{
    public class AssortimentPresent
    {
        private readonly IAssortimentView _AssortimentView;
        private readonly IbakeryView _bakeryView;
        private readonly IdesertsView _desertView;
        private readonly IdrinkView _drinkView;
        private readonly IfirstView _firstView;
        private readonly IsaladView _saladView;
        private readonly IsecondView _secondView;

        public AssortimentPresent(IAssortimentView assortimentView, IbakeryView bakeryView, IdesertsView desertsView, IdrinkView drinkView, IfirstView firstView, IsaladView saladView, IsecondView secondView)
        {

            _AssortimentView = assortimentView;
            _bakeryView = bakeryView;
            _desertView = desertsView;
            _drinkView = drinkView;
            _firstView = firstView;
            _saladView = saladView;
            _secondView = secondView;


            _AssortimentView.LoadMainForm += OnLoadMainForm;
            _AssortimentView.LoadBakeryForm += OnLoadBakeryForm;
            _AssortimentView.LoadDesertsForm += OnLoadDesertForm;
            _AssortimentView.LoadDrinksForm += OnLoadDrinkForm;
            _AssortimentView.LoadFirst_CoursesForm += OnLoadFirstForm;
            _AssortimentView.LoadSaladsForm += OnLoadSaladForm;
            _AssortimentView.LoadSecond_CoursesForm += OnLoadSecondForm;
        }

        private void OnLoadMainForm(object sender, EventArgs e)
        {
            _AssortimentView.Hide();
        }
        private void OnLoadBakeryForm(object sender, EventArgs e)
        {
            _bakeryView.Show();
        }
        private void OnLoadDesertForm(object sender, EventArgs e)
        {
            _desertView.Show();
        }
        private void OnLoadDrinkForm(object sender, EventArgs e)
        {
            _drinkView.Show();
        }
        private void OnLoadFirstForm(object sender, EventArgs e)
        {
            _firstView.Show();
        }
        private void OnLoadSaladForm(object sender, EventArgs e)
        {
            _saladView.Show();
        }
        private void OnLoadSecondForm(object sender, EventArgs e)
        {
            _secondView.Show();
        }
    }
}
