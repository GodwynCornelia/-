using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.View.Main;
using WindowsFormsApp1.View.Postavshik;
using WindowsFormsApp1.View.Product;
using WindowsFormsApp1.View.Assortiment;


namespace WindowsFormsApp1.Presenter
{
    public class MainPresenter
    {
        private readonly IMainView _view;
        private readonly IProvideView _provideView;
        private readonly IProductView _productView;
        private readonly IAssortimentView _assortimentView;


        public MainPresenter(IMainView view, IProvideView provideView, IProductView productView, IAssortimentView assortimentView)
        {
            _view = view;
            _provideView = provideView;
            _productView = productView;
            _assortimentView = assortimentView;
 

            _view.LoadAssortimentForm += OnLoadAssortimentView;
            _view.LoadProductForm += OnLoadProductView;
            _view.LoadProvideForm += OnLoadProvideView;
        }
        private void OnLoadProvideView(object sender, EventArgs e)
        {
            _provideView.Show();
        }
        private void OnLoadProductView(object sender, EventArgs e)
        {
            _productView.Show();
        }
        private void OnLoadAssortimentView(object sender, EventArgs e)
        {

            _assortimentView.Show();
        }

    }
}

