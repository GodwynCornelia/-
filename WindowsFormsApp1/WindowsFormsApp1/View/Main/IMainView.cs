using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.View.Main
{
    public interface IMainView
    {
        event EventHandler LoadProvideForm;
        event EventHandler LoadProductForm;
        event EventHandler LoadAssortimentForm;

        void Hide();
        void Show();
    }
    
}
