using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Model;
using WindowsFormsApp1.Model.Assortiment;
using WindowsFormsApp1.Model.Product;
using WindowsFormsApp1.View.Assortiment.salads;
using WindowsFormsApp1.View.Postavshik;

namespace WindowsFormsApp1.Presenter.delish
{
    public class SaladPresent
    {
        private readonly IsaladView _SaladView;
        private readonly IAssortimentRepository _SaladRepository;

        public SaladPresent(IsaladView saladView, IAssortimentRepository saladRepository)
        {
            _SaladRepository = saladRepository;
            _SaladView = saladView;
            _SaladView.Presenter = this;

            _SaladView.LoadAssortimentForm += OnLoadAssortimentForm;

            UpdateDelishListView();
        }

        public void OnLoadAssortimentForm(object sender, EventArgs e)
        {
            _SaladView.Hide();
        }

        private void UpdateDelishListView()
        {
            var SaladName = from salad in _SaladRepository.GetAllDelish() select salad.Name;
            int selectedSalad = _SaladView.SelectedSalad >= 0 ? _SaladView.SelectedSalad : 0;


            _SaladView.SaladList = SaladName.ToList();
            _SaladView.SelectedSalad = selectedSalad;


            if (SaladName.Any() && selectedSalad >= 0)
            {
                UpdateDelishView(selectedSalad);
            }
            if (SaladName.Any() && selectedSalad >= 0)
            {
                UpdateDelishView(selectedSalad);
            }
        }

        public void UpdateDelishView(int id)
        {
            Delish delish = _SaladRepository.GetDelish(id);
            _SaladView.Name = delish.Name;
            _SaladView.Group = delish.Group;
            _SaladView.Price = delish.Price;
            _SaladView.Exit = delish.Exit;
            _SaladView.Description = delish.Description;

        }

        public void AddDelish()
        {
            var newDelish = new Delish();
            _SaladRepository.AddDelish(newDelish);
            UpdateDelishListView();
        }


    }
}
