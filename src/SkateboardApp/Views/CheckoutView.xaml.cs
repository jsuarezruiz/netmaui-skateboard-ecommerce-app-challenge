using SkateboardApp.ViewModels;

namespace SkateboardApp.Views;

public partial class CheckoutView : ContentPage
{
	public CheckoutView(CheckoutViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = viewModel;
    }
}