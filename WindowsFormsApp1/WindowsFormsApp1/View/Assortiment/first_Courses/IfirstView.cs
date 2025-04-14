using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.View.Assortiment.first_Courses
{
    public interface IfirstView
    {
        event EventHandler LoadAssortimentForm;

        IList<string> FirstList { get; set; }
        int SelectedFirst { get; set; }
        string Name { get; set; }
        string Group { get; set; }

        string Price { get; set; }
        string Exit { get; set; }
        string Description { get; set; }
        void Show();
        void Hide();

        Presenter.delish.FirstPresent Presenter { set; }
    }
}
