using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Model.Assortiment;

namespace WindowsFormsApp1.View.Assortiment.salads
{
    public interface IsaladView
    {
        event EventHandler LoadAssortimentForm;

        IList<string> SaladList { get; set; }
        int SelectedSalad { get; set; }
        string Name { get; set; }
        string Group { get; set; }

        string Price { get; set; }
        string Exit { get; set; }
        string Description { get; set; }

        void Show();
        void Hide();

        Presenter.delish.SaladPresent Presenter { set; }
    }
}
