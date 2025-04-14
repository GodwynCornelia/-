using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.View.Assortiment.drinks
{
    public interface IdrinkView
    {
        event EventHandler LoadAssortimentForm;

        IList<string> DrinkList { get; set; }
        int SelectedDrink { get; set; }
        string Name { get; set; }
        string Group { get; set; }

        string Price { get; set; }
        string Exit { get; set; }
        string Description { get; set; }

        void Show();
        void Hide();

        Presenter.delish.DrinkPresent Presenter { set; }
    }
}
