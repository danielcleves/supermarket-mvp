using Supermarket_mvp.Models;
using Supermarket_mvp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Presenters
{
    internal class CustomerPresenter
    {
        private ICustomerView view;
        private ICustomerRepository repository;
        private BindingSource customerBindingSource;
        private IEnumerable<CustomerModel> customerList;

        public CustomerPresenter(ICustomerView view, ICustomerRepository repository)
        {
            this.customerBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchCustomer;
            this.view.AddNewEvent += AddNewCustomer;
            this.view.EditEvent += LoadSelectedCustomerToEdit;
            this.view.DeleteEvent += DeleteSelectedCustomer;
            this.view.SaveEvent += SaveCustomer;
            this.view.CancelEvent += CancelAction;

            this.view.SetCustomerListBindingSource(customerBindingSource);

            LoadAllCustomerList();

            this.view.Show();
        }

        private void LoadAllCustomerList()
        {
            customerList = repository.GetAll();
            customerBindingSource.DataSource = customerList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveCustomer(object? sender, EventArgs e)
        {
            // Crear un objeto CustomerModel y asignar los valores de la vista
            var customer = new CustomerModel
            {
                Id = Convert.ToInt32(view.CustomerId),           // ID del cliente desde la vista
                DocumentNumber = view.DocumentNumber,             // Número de documento desde la vista
                FirstName = view.FirstName,                       // Nombre desde la vista
                LastName = view.LastName,                         // Apellido desde la vista
                Address = view.Address,                           // Dirección desde la vista
                Birthday = view.Birthday,                        // Fecha de cumpleaños desde la vista
                PhoneNumber = view.PhoneNumber,                   // Número de teléfono desde la vista
                Email = view.Email                        // Correo desde la vista
            };

            try
            {
                // Validar el modelo de datos
                new Common.ModelDataValidation().Validate(customer);

                if (view.IsEdit)
                {
                    repository.Edit(customer);                // Editar el cliente si es una edición
                    view.Message = "Customer edited successfully";
                }
                else
                {
                    repository.Add(customer);                 // Agregar un nuevo cliente
                    view.Message = "Customer added successfully";
                }

                view.IsSuccessful = true;
                LoadAllCustomerList();                       // Recargar la lista de clientes
                CleanViewFields();                           // Limpiar los campos de la vista
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanViewFields()
        {
            view.CustomerId = "0";            // Reiniciar el ID a 0
            view.DocumentNumber = "";          // Limpiar el número de documento
            view.FirstName = "";               // Limpiar el nombre
            view.LastName = "";                // Limpiar el apellido
            view.Address = "";                 // Limpiar la dirección
            view.Birthday = null;              // Limpiar la fecha de cumpleaños
            view.PhoneNumber = "";             // Limpiar el número de teléfono
            view.Email = "";           // Limpiar el correo
        }

        private void DeleteSelectedCustomer(object? sender, EventArgs e)
        {
            try
            {
                var customer = (CustomerModel)customerBindingSource.Current; // Obtener el cliente seleccionado

                repository.Delete(customer.Id);  // Borrar cliente por ID
                view.IsSuccessful = true;
                view.Message = "Customer deleted successfully";
                LoadAllCustomerList();  // Recargar la lista
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error occurred, could not delete customer";
            }
        }

        private void LoadSelectedCustomerToEdit(object? sender, EventArgs e)
        {
            var customer = (CustomerModel)customerBindingSource.Current; // Obtener el cliente seleccionado

            view.CustomerId = customer.Id.ToString();        // Asignar el ID
            view.DocumentNumber = customer.DocumentNumber;   // Asignar el número de documento
            view.FirstName = customer.FirstName;             // Asignar el nombre
            view.LastName = customer.LastName;                // Asignar el apellido
            view.Address = customer.Address;                  // Asignar la dirección
            view.Birthday = customer.Birthday;                // Asignar la fecha de cumpleaños
            view.PhoneNumber = customer.PhoneNumber;          // Asignar el número de teléfono
            view.Email = customer.Email;              // Asignar el correo

            view.IsEdit = true; // Establecer el modo de edición
        }

        private void AddNewCustomer(object? sender, EventArgs e)
        {
            view.IsEdit = false; // Establecer el modo para agregar un nuevo cliente
        }

        private void SearchCustomer(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }



}
