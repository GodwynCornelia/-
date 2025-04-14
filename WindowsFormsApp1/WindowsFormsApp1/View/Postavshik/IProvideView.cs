using System;
using System.Collections.Generic;


namespace WindowsFormsApp1.View.Postavshik
{
    public interface IProvideView
    {
        event EventHandler LoadMainForm;
        IList<string> ProvideList { get; set; }
        int SelectedProvide { get; set; }
        string Name { get; set; }
        string Addres { get; set; }
        string FIO { get; set; }
        string Phone { get; set; }
        string Bank { get; set; }
        string Check { get; set; }
        string INN { get; set; }

        void Show();
        void Hide();
        Presenter.ProvidePresenter Presenter { set; }
    }
}
