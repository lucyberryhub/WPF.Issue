using System.ComponentModel;

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
