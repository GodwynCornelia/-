using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Model.Assortiment;
using WindowsFormsApp1.Model.Assortiment.Interface;
using WindowsFormsApp1.View.Assortiment.first_Courses;
using WindowsFormsApp1.View.Assortiment.salads;

namespace WindowsFormsApp1.Presenter.delish
{
    public class FirstPresent
    {
        private readonly IfirstView _firstView;
        private readonly IFirstRepository _firstRepository;

        public FirstPresent(IfirstView firstView, IFirstRepository firstRepository)
        {
            _firstRepository = firstRepository;
            _firstView = firstView;
            _firstView.Presenter = this;

            _firstView.LoadAssortimentForm += OnLoadAssortimentForm;

            UpdateDelishListView();
        }

        public void OnLoadAssortimentForm(object sender, EventArgs e)
        {
            _firstView.Hide();
        }

        private void UpdateDelishListView()
        {
            var firstName = from first in _firstRepository.GetAllFirst() select first.Name;
            int selectedfirst = _firstView.SelectedFirst >= 0 ? _firstView.SelectedFirst : 0;


            _firstView.FirstList = firstName.ToList();
            _firstView.SelectedFirst = selectedfirst;


            if (firstName.Any() && selectedfirst >= 0)
            {
                UpdateDelishView(selectedfirst);
            }
        }

        public void UpdateDelishView(int id)
        {
            Delish delish = _firstRepository.GetFirst(id);
            _firstView.Name = delish.Name;
            _firstView.Group = delish.Group;
            _firstView.Price = delish.Price;
            _firstView.Exit = delish.Exit;
            _firstView.Description = delish.Description;

        }

        public void AddDelish()
        {
            var newDelish = new Delish();
            _firstRepository.AddFirst(newDelish);
            UpdateDelishListView();
        }
    }
}
