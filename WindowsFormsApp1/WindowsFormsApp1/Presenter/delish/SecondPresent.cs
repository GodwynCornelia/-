using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Model.Assortiment;
using WindowsFormsApp1.View.Assortiment.salads;
using WindowsFormsApp1.View.Assortiment.second_Courses;

namespace WindowsFormsApp1.Presenter.delish
{
    public class SecondPresent
    {
        private readonly IsecondView _secondView;
        private readonly IAssortimentRepository _SecondRepository;

        public SecondPresent(IsecondView secondView, IAssortimentRepository secondRepository)
        {
            _SecondRepository = secondRepository;
            _secondView = secondView;
            _secondView.Presenter = this;

            _secondView.LoadAssortimentForm += OnLoadAssortimentForm;

            UpdateDelishListView();
        }

        public void OnLoadAssortimentForm(object sender, EventArgs e)
        {
            _secondView.Hide();
        }

        private void UpdateDelishListView()
        {
            var SecondName = from second in _SecondRepository.GetAllDelish() select second.Name;
            int selectedSalad = _secondView.SelectedSecond >= 0 ? _secondView.SelectedSecond : 0;


            _secondView.SecondList = SecondName.ToList();
            _secondView.SelectedSecond = selectedSalad;


            if (SecondName.Any() && selectedSalad >= 0)
            {
                UpdateDelishView(selectedSalad);
            }
   
        }

        public void UpdateDelishView(int id)
        {
            Delish delish = _SecondRepository.GetDelish(id);
            _secondView.Name = delish.Name;
            _secondView.Group = delish.Group;
            _secondView.Price = delish.Price;
            _secondView.Exit = delish.Exit;
            _secondView.Description = delish.Description;

        }

        public void AddDelish()
        {
            var newDelish = new Delish();
            _SecondRepository.AddDelish(newDelish);
            UpdateDelishListView();
        }
    }
}
