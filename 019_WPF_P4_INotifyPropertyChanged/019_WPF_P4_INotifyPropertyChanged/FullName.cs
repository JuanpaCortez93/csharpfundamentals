using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _019_WPF_P4_INotifyPropertyChanged
{
     class FullName : INotifyPropertyChanged
    {
        private string _firstName;
        private string _lastName;
        private string _fullName;

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {

            if (PropertyChanged != null) { PropertyChanged(this, new PropertyChangedEventArgs(propertyName)); }

        }

        public string FirstName { get { return _firstName; } set {  _firstName = value; OnPropertyChanged("FullNameComplete"); } }
        public string LastName { get { return _lastName; } set { _lastName = value; OnPropertyChanged("FullNameComplete"); } }
        public string FullNameComplete
        {
            get {
                _fullName = FirstName + " " + LastName;
                return _fullName; 
            } 
        }


    }
}
