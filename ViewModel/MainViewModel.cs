

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace MAUI_WORKSHOP.ViewModel
{
    /// <summary>
    /// Codigo del ViewModel
    /// </summary>
    public partial class MainViewModel : ObservableObject //Esta clase viene de un paquete NuGet llamado CommunityToolkit.MVVM. Se hace uso de la clase parcial, para asi poder añadir codigo a la clase.
    {
        public MainViewModel()
        {
            _items = new ObservableCollection<string>(); //_items = new ObservableCollection<string>();: Se asigna la nueva instancia de ObservableCollection<string> a la variable _items. Esta variable es una propiedad de la clase MainViewModel que se usa para almacenar la colección de elementos.
        }
        [ObservableProperty]
        ObservableCollection<string> _items; //new ObservableCollection<string>(): Se crea una nueva instancia de la clase ObservableCollection<string>. La clase ObservableCollection<T> es una colección genérica en C# que proporciona notificaciones de cambio automáticas cuando se agregan, eliminan o actualizan elementos dentro de la colección.

        [ObservableProperty]
        string text;

        /// <summary>
        /// Funcionalidad del boton agregar
        /// </summary>
        [RelayCommand]
        void Add()
        {
            if (string.IsNullOrEmpty(text))
                return; //si el texto es nulo o esta vacio, vamos a salir del metodo
            _items.Add(text);
            Text = string.Empty;
        }

        [RelayCommand]
        void Delete(string text)
        {
            if (_items.Contains(text))
            {
                _items.Remove(text);

            }
        }

    }
}
