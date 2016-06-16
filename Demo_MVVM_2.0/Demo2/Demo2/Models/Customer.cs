using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2.Models
{
    class Customer:INotifyPropertyChanged, IDataErrorInfo
    {

        private string name;
        private string lastN;
        private string email;
        public Customer()
        {

        }

        public Customer(String customerName, String customerLastN, String customerEmail)
        {
            Name = customerName;
            LastN = customerLastN;
            Email = customerEmail; 
        }        

        public String Name {
            get {
                return name;
            }
            set {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        public String LastN
        {
            get
            {
                return lastN;
            }
            set
            {
                lastN = value;
                OnPropertyChanged("LastN");
            }
        }

        public String Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
                OnPropertyChanged("Email");
            }
        }        

        //For handling property changes
        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
             if(handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion


        //Validation 
        #region IDataErrorInfo Members         
        public string Error
        {
            get;
            private set;
        }

        public string this[string columnName]
        {
            get
            {
                if(columnName == "Name")
                {
                    //if name length is < 2 or is null or a whitespace 
                    if (String.IsNullOrWhiteSpace(Name) || (Name.Length < 2)) 
                    {
                        Error = "You need to write a valid name";
                    }
                    else Error = null;
                }

                if (columnName == "LastN")
                {
                    //if last name length is < 2 or is null or a whitespace 
                    if (String.IsNullOrWhiteSpace(LastN) || (LastN.Length < 2))
                    {
                        Error = "You need to write a valid last name";
                    }
                    else Error = null;
                }

                if (columnName == "Email")
                {
                    //if email length is < 2 or is null or a whitespace 
                    if (String.IsNullOrWhiteSpace(Email) || (LastN.Length < 7)) 
                    {
                        Error = "You need to write a valid email";
                    }
                    else Error = null;
                }

                return Error;
            }
        }
        #endregion
    }
}
