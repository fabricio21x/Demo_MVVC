using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2.Models
{
    class Customer:INotifyPropertyChanged
    {
        public Customer(String customerName, String customerLastN, String customerEmail)
        {
            Name = customerName;
            LastN = customerLastN;
            Email = customerEmail; 
        }

        private string _Name;

        public String Name {
            get {
                return _Name;
            }
            set {
                _Name = value;
                OnPropertyChanged("Name");
            }
        }

        private string _LastN;
        public String LastN
        {
            get
            {
                return _LastN;
            }
            set
            {
                _LastN = value;
                OnPropertyChanged("LastN");
            }
        }

        private string _Email;
        public String Email
        {
            get
            {
                return _Email;
            }
            set
            {
                _Email = value;
                OnPropertyChanged("Email");
            }
        }

        //public String Full
        //{
        //    get { return String.Format("Hello {0} {1} ({2}), this is a demo program", Name,LastN,Email); }

        //}


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
    }
}
