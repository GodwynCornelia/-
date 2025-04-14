using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Model;
using WindowsFormsApp1.View.Postavshik;

namespace WindowsFormsApp1.Presenter
{
    public class ProvidePresenter
    {
        private readonly IProvideRepository _provideRepository;
        private readonly  IProvideView _provideView;


        public ProvidePresenter(IProvideView provideView, IProvideRepository provideRepository)
        {

            _provideRepository = provideRepository;
            _provideView = provideView;
            provideView.Presenter = this;

            _provideView.LoadMainForm += OnLoadMainForm;

            UpdateProvideListView();
        }

        private void OnLoadMainForm(object sender, EventArgs e)
        {
            _provideView.Hide();
        }

        private void UpdateProvideListView()
        {
            var providesName = from provide in _provideRepository.GetAllProvides() select provide.Name;
            int selectedProvide = _provideView.SelectedProvide >= 0 ? _provideView.SelectedProvide : 0;

            _provideView.ProvideList = providesName.ToList();
            _provideView.SelectedProvide = selectedProvide;

            if (providesName.Any() && selectedProvide >= 0)
            {
                UpdateProvideView(selectedProvide);
            }
        }

        public void UpdateProvideView(int id)
        {
            Provide provide = _provideRepository.GetProvide(id);
            _provideView.Name = provide.Name;
            _provideView.Addres = provide.Addres;
            _provideView.FIO = provide.FIO;
            _provideView.Phone = provide.Phone;
            _provideView.Bank = provide.Bank;
            _provideView.Check = provide.Check;
            _provideView.INN = provide.INN;
            
        }

        public void AddProvide() {
            var newProvide = new Provide();
            _provideRepository.AddProvide(newProvide);
            UpdateProvideListView();
        }

       
    }
}
