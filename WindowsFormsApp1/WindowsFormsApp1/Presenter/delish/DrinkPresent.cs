using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Model.Assortiment;
using WindowsFormsApp1.Model.Assortiment.Interface;
using WindowsFormsApp1.View.Assortiment.deserts;
using WindowsFormsApp1.View.Assortiment.drinks;

namespace WindowsFormsApp1.Presenter.delish
{
    public class DrinkPresent
    {
        private readonly IdrinkView _DrinkView;
        private readonly IDrinkRepository _drinkRepository;

        public DrinkPresent(IdrinkView drinkView, IDrinkRepository drinkRepository)
        {
            _drinkRepository= drinkRepository;  
            _DrinkView = drinkView;
            _DrinkView.Presenter = this;

            _DrinkView.LoadAssortimentForm += OnLoadAssortimentForm;
            UpdateDelishListView();
        }

        public void OnLoadAssortimentForm(object sender, EventArgs e)
        {
            _DrinkView.Hide();
        }

        private void UpdateDelishListView()
        {
            var DesertName = from drink in _drinkRepository.GetAllDrink() select drink.Name;
            int selectedDesert = _DrinkView.SelectedDrink >= 0 ? _DrinkView.SelectedDrink : 0;


            _DrinkView.DrinkList = DesertName.ToList();
            _DrinkView.SelectedDrink = selectedDesert;


            if (DesertName.Any() && selectedDesert >= 0)
            {
                UpdateDelishView(selectedDesert);
            }
        }

        public void UpdateDelishView(int id)
        {
            Delish delish = _drinkRepository.GetDrink(id);
            _DrinkView.Name = delish.Name;
            _DrinkView.Group = delish.Group;
            _DrinkView.Price = delish.Price;
            _DrinkView.Exit = delish.Exit;
            _DrinkView.Description = delish.Description;

        }

        public void AddDelish()
        {
            var newDelish = new Delish();
            _drinkRepository.AddDrink(newDelish);
            UpdateDelishListView();
        }
    }
}
