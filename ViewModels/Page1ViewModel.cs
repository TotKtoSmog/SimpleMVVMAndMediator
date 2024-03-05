using SimpleMVVMAndMediator.Model;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace SimpleMVVMAndMediator.ViewModels
{
    public class Page1ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string name = "")
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        private string _address;
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
                OnPropertyChanged();
            }
        }

        private string _description;
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
                OnPropertyChanged();
            }
        }

        private User _userDate;
        public User UserDate
        {
            get 
            { 
                return _userDate; 
            }
            set
            {
                _userDate = value;
                OnPropertyChanged();
            }
        }
        private string _resultDate;
        public string ResultDate
        {
            get 
            { 
                return _resultDate; 
            }
            set
            {
                _resultDate = value;
                OnPropertyChanged();
            }
        }
        public Page1ViewModel()
        {
            Name = "";
            Address = "";
            Description = "";
            ResultDate = "";
            UserDate = new User("", "", "");
        }
    }
}
