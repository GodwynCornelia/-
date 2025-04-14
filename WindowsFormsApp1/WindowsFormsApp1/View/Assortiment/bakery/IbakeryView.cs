using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Presenter.delish;

namespace WindowsFormsApp1.View.Assortiment.bakery
{
    public interface IbakeryView
    {
        event EventHandler LoadAssortimentForm;

        IList<string> BakeryList { get; set; }
        int SelectedBakery { get; set; }
        string Name { get; set; }
        string Group { get; set; }

        string Price { get; set; }
        string Exit { get; set; }
        string Description { get; set; }
        void Show();
        void Hide();

        Presenter.delish.BakeryPresent Presenter { set; }
    }
}
