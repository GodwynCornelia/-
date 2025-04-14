using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Model;
using WindowsFormsApp1.Model.Product;
using WindowsFormsApp1.View.Postavshik;
using WindowsFormsApp1.View.Product;

namespace WindowsFormsApp1.Presenter
{
    public class ProductPresenter
    {
        private readonly IProductRepository _productRepository;
        private readonly IProductView _productView;
        private IAdderProductView _adderProductView;


        public ProductPresenter(IProductView productView, IProductRepository productRepository)
        {

            _productRepository = productRepository;
            _productView = productView;
            _productView.Presenter = this;

            _productView.LoadMainForm += OnLoadMainForm;

            UpdateProductListView();
        }

        private void OnLoadMainForm(object sender, EventArgs e)
        {
            _productView.Hide();
        }

        public void SetAdderProductView(IAdderProductView adderView)
        {
            _adderProductView = adderView;
            adderView.presenter = this;
        }

        private void UpdateProductListView()
        {
            var productName = from product in _productRepository.GetAllProducts() select product.Name;
            int selectedProduct = _productView.SelectedProduct >= 0 ? _productView.SelectedProduct : 0;

            _productView.ProductList = productName.ToList();
            _productView.SelectedProduct = selectedProduct;

            if (productName.Any() && selectedProduct >= 0)
            {
                UpdateProductView(selectedProduct);
            }
        }

        public void UpdateProductView(int id)
        {
            var product = _productRepository.GetProduct(id);
            if (product == null) return;

            _productView.Name = product.Name;
            _productView.Unit = product.Unit;
            _productView.Overprice = product.Overprice;
            _productView.Remains = product.Remains;
            _productView.Provide = product.Provide;

        }

        public void SaveProduct()
        {
            var updatedProduct = new Product(
            _productView.Name,
            _productView.Unit,
            _productView.Overprice,
            _productView.Remains,
            _productView.Provide

            );

            _productRepository.UpdateProduct(_productView.SelectedProduct, updatedProduct);
            UpdateProductListView();
        }

        public void DeleteProduct()
        {
            if (_productView.SelectedProduct < 0) return;


            _productRepository.DeleteProduct(_productView.SelectedProduct);

            UpdateProductListView();
        }

        public void AddProduct()
        {
            Product newProduct = new Product(
            _adderProductView.NameProduct,
            _adderProductView.Unit,
            _adderProductView.Overprice,
           _adderProductView.Remains,
            _adderProductView.Provide
               
            );
            _productRepository.AddProduct(newProduct);
            UpdateProductListView();
        }
    }
}
