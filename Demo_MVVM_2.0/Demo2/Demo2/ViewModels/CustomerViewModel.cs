using Demo2.Commands;
using Demo2.Models;
using Demo2.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Demo2.ViewModels
{
    class CustomerViewModel
    {
        private Customer customer;
        private CustomerInfoViewModel childViewModel; //this will manage the view after clicking the button

        public CustomerViewModel()
        {
            customer = new Customer();
            childViewModel = new CustomerInfoViewModel();
            UpdateCommand = new CustomerUpdateCommand(this);
        }
        
        public Customer Customer {
            get{return customer;}
        }

        public ICommand UpdateCommand
        {
            get;
            private set;
        }
        public void SaveChanges()
        {
            CustomerInfoView view = new CustomerInfoView();
            view.DataContext = childViewModel;
            childViewModel.Info = "This is the information you provided: \n" +
                "Full name: " + Customer.Name + " "
                + Customer.LastN + " and the email direction you entered is " +
                Customer.Email;
            view.ShowDialog();
        }
    }
}
