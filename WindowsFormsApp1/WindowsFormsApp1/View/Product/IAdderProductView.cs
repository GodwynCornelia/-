using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Presenter;

namespace WindowsFormsApp1.View.Product
{
    public interface IAdderProductView
    {
        string NameProduct { get; set; }
        string Unit { get; set; }
        string Overprice { get; set; }
        string Remains { get; set; }
        Provide Provide { get; set; }
        Presenter.ProductPresenter presenter { set; }
    }
}
