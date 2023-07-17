
using Microsoft.Maui.Controls.Compatibility;
using System.ComponentModel;

namespace MAUI_WORKSHOP.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public string Text 
        {
            get => Text;
            set
            {
                Text = value;
                OnPropertyChanged(nameof(Text));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged; //Implemento la interfaz
        
        void OnPropertyChanged(string propertyName) //Creo un metodo que usa
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName)); // Esto levanta el evento PropertieChanged y cambiara la propiedad indicada
        }
    }
}
