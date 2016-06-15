using Demo2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Demo2.Commands
{
    //internal class CustomerUpdateCommand : ICommand
    //{
    //    //constructor
    //    public CustomerUpdateCommand(CustomerViewModel viewmodel)
    //    {
    //        _ViewModel = viewmodel;
    //    }

    //    private CustomerViewModel _ViewModel;

    //    #region ICommand Members
    //    public event EventHandler CanExecuteChanged
    //    {
    //        //pass our events to the command manager
    //        add { CommandManager.RequerySuggested += value; } 
    //        remove { CommandManager.RequerySuggested -= value; }
    //    }

    //    //the button will enable or disable based on the return of this method
    //    public bool CanExecute(object parameter)
    //    {
    //        return _ViewModel.CanUpdate; //we will implement this logic in our view-model class
    //    }


    //    public void Execute(object parameter)
    //    {
    //        _ViewModel.SaveChanges();
    //    }
    //    #endregion

    //}
}
