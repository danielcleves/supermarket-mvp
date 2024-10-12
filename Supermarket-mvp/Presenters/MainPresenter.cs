using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.Models;
using Supermarket_mvp.Views;
using Supermarket_mvp._Repositories;

namespace Supermarket_mvp.Presenters
{
    internal class MainPresenter
    {
        private readonly IMainView mainView;
        private readonly string sqlConnectionString;

        public MainPresenter(IMainView mainView, string sqlConnectionString)
        {
            this.mainView = mainView;
            this.sqlConnectionString = sqlConnectionString;

            this.mainView.ShowPayModeView += ShowPayModeView;
            this.mainView.ShowCategoryView += ShowCategoryView; // Manejo de la vista de Category
            this.mainView.ShowCustomerView += ShowCustomerView; // Manejo de la vista de Customers
            this.mainView.ShowProductView += ShowProductView; // Agregado para manejar la vista de Products
        }

        private void ShowPayModeView(object? sender, EventArgs e)
        {
            IPayModeView view = PayModeView.GetInstance((MainView)mainView);
            IPayModeRepository repository = new PayModeRepository(sqlConnectionString);
            new PayModePresenter(view, repository);
        }

        private void ShowCategoryView(object? sender, EventArgs e)
        {
            ICategoryView view = CategoryView.GetInstance((MainView)mainView); // Obtener la instancia de la vista de Category
            ICategoryRepository repository = new CategoryRepository(sqlConnectionString); // Crear el repositorio de Category
            new CategoryPresenter(view, repository); // Crear el presentador de Category
        }

        private void ShowCustomerView(object? sender, EventArgs e)
        {
            ICustomerView view = CustomerView.GetInstance((MainView)mainView); // Obtener la instancia de la vista de Customers
            ICustomerRepository repository = new CustomerRepository(sqlConnectionString); // Crear el repositorio de Customers
            new CustomerPresenter(view, repository); // Crear el presentador de Customers
        }

        private void ShowProductView(object? sender, EventArgs e) // Método agregado para manejar la vista de Products
        {
            IProductView view = ProductView.GetInstance((MainView)mainView); // Obtener la instancia de la vista de Products
            IProductRepository repository = new ProductRepository(sqlConnectionString); // Crear el repositorio de Products
            new ProductPresenter(view, repository); // Crear el presentador de Products
        }
    }
}
