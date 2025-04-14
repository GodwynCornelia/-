using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;
using WindowsFormsApp1.Model.Assortiment;
using WindowsFormsApp1.Model.Product;
using WindowsFormsApp1.Model.Product.WindowsFormsApp1.Model;
using WindowsFormsApp1.Presenter;
using WindowsFormsApp1.Presenter.delish;
using WindowsFormsApp1.View.Main;
using WindowsFormsApp1.View.Postavshik;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var view = new Form1();
            var viewProvide = new allPostavshik();
            var viewProduct = new Form3();
            var viewAssortiment = new Assortiment();
            var viewBakery = new bakery();
            var viewDesert = new deserts();
            var viewDrink = new drinks();
            var viewFirst = new first_Сourses();
            var viewSalad = new salads();
            var viewSecond = new second_Courses();

            var ProvideRepository = new ProvideJsonRepository("provide.json");
            var ProductRepository = new ProductJsonRepository("product.json");
            var SaladRepository = new SaladJsonRepository("salad.json");
            var FirstRepository = new FirstJsonRepository("first.json");
            var SecondRepository = new SecondJsonRepository("second.json");
            var DesertRepository = new DesertJsonRepository("desert.json");
            var DrinkRepository = new DrinkJsonRepository("drink.json");
            var BakeryRepository = new BakeryJsonRepository("bakery.json");

            var mainPresenter = new MainPresenter(view, viewProvide, viewProduct, viewAssortiment);
            var providePresenter = new ProvidePresenter( viewProvide, ProvideRepository);
            var productPresenter = new ProductPresenter( viewProduct, ProductRepository);
            var assortimentPresenter = new AssortimentPresent(viewAssortiment, viewBakery, viewDesert, viewDrink, viewFirst, viewSalad, viewSecond);

            var bakeryPresenter = new BakeryPresent(viewBakery, BakeryRepository);
            var desertPresenter = new DesertPresent(viewDesert, DesertRepository);
            var drinkPresenter = new DrinkPresent(viewDrink, DrinkRepository);
            var firstPresenter = new FirstPresent(viewFirst, FirstRepository);
            var saladPresenter = new SaladPresent(viewSalad, SaladRepository);
            var secondPresenter = new SecondPresent(viewSecond, SecondRepository);


            Application.Run(view);
        }
    }
}
