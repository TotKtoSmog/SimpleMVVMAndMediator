using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SimpleMVVMAndMediator.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string name = "")
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        private string _sourcePage1;
        public string SourcePage1
        {
            get 
            { 
                return _sourcePage1; 
            }
            set 
            { 
                _sourcePage1 = value;
                OnPropertyChanged();
            }
        }
        private string _sourcePage2;
        public string SourcePage2
        {
            get
            {
                return _sourcePage2;
            }
            set
            {
                _sourcePage2 = value;
                OnPropertyChanged();
            }
        }

        public MainWindowViewModel()
        {
            SourcePage1 = "Page1.xaml";
            SourcePage2 = "Page2.xaml";
        }
    }
}
