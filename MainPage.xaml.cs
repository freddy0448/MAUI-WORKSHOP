using MAUI_WORKSHOP.ViewModel;

namespace MAUI_WORKSHOP;

public partial class MainPage : ContentPage
{

	public MainPage(MainViewModel viewModel) //Inyeccion de dependecias
	{
		InitializeComponent();
		BindingContext = viewModel; //El contexto que usara el MainPage sera el definido aqui
	}

}

