using Supermarket_mvp.Models;
using Supermarket_mvp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Presenters
{
    internal class CategoryPresenter
    {
        private ICategoryView view;
        private ICategoryRepository repository;
        private BindingSource categoryBindingSource;
        private IEnumerable<CategoryModel> categoryList;

        public CategoryPresenter(ICategoryView view, ICategoryRepository repository)
        {
            this.categoryBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchCategory;
            this.view.AddNewEvent += AddNewCategory;
            this.view.EditEvent += LoadSelectedCategoryToEdit;
            this.view.DeleteEvent += DeleteSelectedCategory;
            this.view.SaveEvent += SaveCategory;
            this.view.CancelEvent += CancelAction;

            this.view.SetCategoryListBindingSource(categoryBindingSource);

            LoadAllCategoryList();

            this.view.Show();
        }

        private void LoadAllCategoryList()
        {
            categoryList = repository.GetAll();
            categoryBindingSource.DataSource = categoryList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveCategory(object? sender, EventArgs e)
        {
            var category = new CategoryModel
            {
                Id = Convert.ToInt32(view.CategoryId),
                Name = view.CategoryName,
                Description = view.CategoryDescription
            };

            try
            {
                new Common.ModelDataValidation().Validate(category);
                if (view.IsEdit)
                {
                    repository.Edit(category);
                    view.Message = "Categoría editada exitosamente";
                }
                else
                {
                    repository.Add(category);
                    view.Message = "Categoría agregada exitosamente";
                }
                view.IsSuccessful = true;
                LoadAllCategoryList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanViewFields()
        {
            view.CategoryId = "0";
            view.CategoryName = "";
            view.CategoryDescription = "";
        }

        private void DeleteSelectedCategory(object? sender, EventArgs e)
        {
            try
            {
                var category = (CategoryModel)categoryBindingSource.Current;
                repository.Delete(category.Id);

                view.IsSuccessful = true;
                view.Message = "Categoría eliminada exitosamente";
                LoadAllCategoryList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "Ocurrió un error, no se pudo eliminar la categoría";
            }
        }

        private void LoadSelectedCategoryToEdit(object? sender, EventArgs e)
        {
            var category = (CategoryModel)categoryBindingSource.Current;

            view.CategoryId = category.Id.ToString();
            view.CategoryName = category.Name;
            view.CategoryDescription = category.Description;

            view.IsEdit = true;
        }

        private void AddNewCategory(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchCategory(object? sender, EventArgs e)
        {
            var searchValue = view.SearchValue;

            if (string.IsNullOrWhiteSpace(searchValue)) // Verifica si searchValue es vacío o solo espacios
            {
                // Si está vacío, obtén todos los elementos de la lista de categorías
                categoryList = repository.GetAll(); // Suponiendo que tienes un método GetAll en tu repositorio
            }
            else
            {
                // Si no está vacío, busca por el valor proporcionado
                categoryList = repository.GetByValue(searchValue);
            }

            categoryBindingSource.DataSource = categoryList; // Actualiza el origen de datos
        }

    }

}
