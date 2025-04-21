using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Model.Assortiment;
using WindowsFormsApp1.View.Assortiment;
using WindowsFormsApp1.View.Assortiment.bakery;
using WindowsFormsApp1.View.Assortiment.deserts;
using WindowsFormsApp1.View.Postavshik;

namespace WindowsFormsApp1.Presenter.delish
{
    public class BakeryPresent
    {
        private readonly IbakeryView _BakeryView;
        private readonly IBakeryRepository _BakeryRepository;

        public BakeryPresent(IbakeryView bakeryView, IBakeryRepository BakeryRepository)
        {
            _BakeryRepository = BakeryRepository;
            _BakeryView = bakeryView;
            _BakeryView.Presenter = this;

            _BakeryView.LoadAssortimentForm += OnLoadAssortimentForm;
            UpdateDelishListView();
        }

        public void OnLoadAssortimentForm(object sender, EventArgs e)
        {
            _BakeryView.Hide();
        }
        private void UpdateDelishListView()
        {
            var BakeryName = from bakery in _BakeryRepository.GetAllBakery() select bakery.Name;
            int selectedBakery = _BakeryView.SelectedBakery >= 0 ? _BakeryView.SelectedBakery : 0;


            _BakeryView.BakeryList = BakeryName.ToList();
            _BakeryView.SelectedBakery = selectedBakery;


            if (BakeryName.Any() && selectedBakery >= 0)
            {
                UpdateDelishView(selectedBakery);
            }
        }

        public void UpdateDelishView(int id)
        {
            Delish delish = _BakeryRepository.GetBakery(id);
            _BakeryView.Name = delish.Name;
            _BakeryView.Group = delish.Group;
            _BakeryView.Price = delish.Price;
            _BakeryView.Exit = delish.Exit;
            _BakeryView.Description = delish.Description;

        }

        public void AddDelish()
        {
            var newDelish = new Delish();
            _BakeryRepository.AddBakery(newDelish);
            UpdateDelishListView();
        }
    }
}
