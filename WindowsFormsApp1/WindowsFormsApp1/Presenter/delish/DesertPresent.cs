using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Model.Assortiment;
using WindowsFormsApp1.Model.Assortiment.Interface;
using WindowsFormsApp1.View.Assortiment.bakery;
using WindowsFormsApp1.View.Assortiment.deserts;
using WindowsFormsApp1.View.Assortiment.salads;

namespace WindowsFormsApp1.Presenter.delish
{
    public class DesertPresent
    {
        private readonly IdesertsView _DesertView;
        private readonly IDesertRepository _DesertRepository;

        public DesertPresent(IdesertsView desertView, IDesertRepository desertRepository)
        {
            _DesertRepository = desertRepository;
            _DesertView = desertView;
            _DesertView.Presenter = this;

            _DesertView.LoadAssortimentForm += OnLoadAssortimentForm;
            UpdateDelishListView();
        }

        public void OnLoadAssortimentForm(object sender, EventArgs e)
        {
            _DesertView.Hide();
        }
        private void UpdateDelishListView()
        {
            var DesertName = from desert in _DesertRepository.GetAllDesert() select desert.Name;
            int selectedDesert = _DesertView.SelectedDesert >= 0 ? _DesertView.SelectedDesert : 0;


            _DesertView.DesertList = DesertName.ToList();
            _DesertView.SelectedDesert = selectedDesert;


            if (DesertName.Any() && selectedDesert >= 0)
            {
                UpdateDelishView(selectedDesert);
            }
        }

        public void UpdateDelishView(int id)
        {
            Delish delish = _DesertRepository.GetDesert(id);
            _DesertView.Name = delish.Name;
            _DesertView.Group = delish.Group;
            _DesertView.Price = delish.Price;
            _DesertView.Exit = delish.Exit;
            _DesertView.Description = delish.Description;

        }

        public void AddDelish()
        {
            var newDelish = new Delish();
            _DesertRepository.AddDesert(newDelish);
            UpdateDelishListView();
        }
    }
}
