using CommunityToolkit.Mvvm.ComponentModel;
using Fukusei.Model;

namespace Fukusei.ViewModel;

public partial class MainViewModel : ObservableObject
{
    private readonly MainModel _model;

    [ObservableProperty] private string _name;
    partial void OnNameChanged(string value) => _model.Name = value;

    public MainViewModel()
    {
        _model = new MainModel();
    }
}