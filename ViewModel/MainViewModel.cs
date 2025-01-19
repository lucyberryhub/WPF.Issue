using System.Collections.ObjectModel;
using System.ComponentModel;

namespace TroubleBerry.WPF.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private Berry _selectedBerry;

        public ObservableCollection<Berry> Berries { get; set; }

        public Berry SelectedBerry
        {
            get => _selectedBerry;
            set
            {
                _selectedBerry = value;
                OnPropertyChanged(nameof(SelectedBerry));
            }
        }

        public MainViewModel()
        {
            Berries = new ObservableCollection<Berry>
            {
                new Berry { BerryName = "Strawberry", BerryCount = 20 },
                new Berry { BerryName = "Blueberry", BerryCount = 15 },
                new Berry { BerryName = "Raspberry", BerryCount = 30 }
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class Berry : INotifyPropertyChanged
    {
        private string _berryName;
        private double _berryCount;

        public string BerryName
        {
            get => _berryName;
            set
            {
                _berryName = value;
                OnPropertyChanged(nameof(BerryName));
            }
        }

        public double BerryCount
        {
            get => _berryCount;
            set
            {
                _berryCount = value;
                OnPropertyChanged(nameof(BerryCount));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
