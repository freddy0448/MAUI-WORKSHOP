

using CommunityToolkit.Mvvm.ComponentModel;

namespace MAUI_WORKSHOP.ViewModel
{
    public partial class MainViewModel : ObservableObject //Esta clase viene de un paquete NuGet llamado CommunityToolkit.MVVM. Se hace uso de la clase parcial, para asi poder añadir codigo a la clase.
    {
        [ObservableProperty]
        string text;
    }
}
