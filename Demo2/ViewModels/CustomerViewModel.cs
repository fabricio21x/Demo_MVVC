using Demo2.Commands;
using Demo2.Models;
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
        public CustomerViewModel()
        {
            _Customer = new Customer("Fabricio","Monsalve","fmonsalve@pucp.pe");
            //UpdateCommand = new CustomerUpdateCommand(this);
        }

        private Customer _Customer;
        public Customer Customer {
            get{return _Customer;}
        }

        //public ICommand UpdateCommand
        //{
        //    get ;
        //    private set;
        //}
        //public bool CanUpdate {
        //    get {
        //        if (Customer == null){
        //            return false;
        //        }                    
        //        return (!String.IsNullOrWhiteSpace(Customer.Name) &&
        //            !String.IsNullOrWhiteSpace(Customer.LastN) &&
        //            !String.IsNullOrWhiteSpace(Customer.Email));                 
        //    }
        //}

        //public void SaveChanges()
        //{
        //    Debug.Assert(false, String.Format("Customer info was changed"));
        //}
    }
}
