using Demo2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Demo2.Commands
{
    internal class CustomerUpdateCommand : ICommand
    {

        private CustomerViewModel ViewModel;
        //constructor
        public CustomerUpdateCommand(CustomerViewModel viewmodel)
        {
            this.ViewModel = viewmodel;
        }       

        #region ICommand Members
        public event EventHandler CanExecuteChanged
        {
            //pass our events to the command manager
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        //the button will enable or disable based on the return of this method
        public bool CanExecute(object parameter)
        {
            return String.IsNullOrWhiteSpace(ViewModel.Customer.Error); 
        }


        public void Execute(object parameter)
        {
            ViewModel.SaveChanges();
        }
        #endregion

    }
}
