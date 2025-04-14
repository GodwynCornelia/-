using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.View.Product
{
    public interface IProductView
    {
        event EventHandler LoadMainForm;
        IList<string> ProductList { get; set; }
        int SelectedProduct { get; set; }
        string Name { get; set; }
        string Unit { get; set; }
        string Overprice { get; set; }
        string Remains { get; set; }
        Provide Provide { get; set; }

        void Show();
        void Hide();
        Presenter.ProductPresenter Presenter { get; set; }
    }
}
