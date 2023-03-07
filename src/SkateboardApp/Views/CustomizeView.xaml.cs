using SkateboardApp.ViewModels;

namespace SkateboardApp.Views;

public partial class CustomizeView : ContentPage
{
	public CustomizeView(CustomizeViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = viewModel;
    }
}