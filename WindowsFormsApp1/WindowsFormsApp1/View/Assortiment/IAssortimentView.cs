using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.View.Assortiment
{
    public interface IAssortimentView
    {
        event EventHandler LoadMainForm;
        
       event EventHandler LoadSaladsForm;
       event EventHandler LoadFirst_CoursesForm;
       event EventHandler LoadSecond_CoursesForm;
      event EventHandler LoadDesertsForm;
       event EventHandler LoadDrinksForm;
       event EventHandler LoadBakeryForm;
        void Show();
        void Hide();
        Presenter.AssortimentPresent Presenter {set; }
    }
}
