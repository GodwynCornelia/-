using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.View.Assortiment.deserts
{
    public interface IdesertsView
    {
        event EventHandler LoadAssortimentForm;

        IList<string> DesertList { get; set; }
        int SelectedDesert { get; set; }
        string Name { get; set; }
        string Group { get; set; }

        string Price { get; set; }
        string Exit { get; set; }
        string Description { get; set; }

        void Show();
        void Hide();

        Presenter.delish.DesertPresent Presenter { set; }
    }
}
