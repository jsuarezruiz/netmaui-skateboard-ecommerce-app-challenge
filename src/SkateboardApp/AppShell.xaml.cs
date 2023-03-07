using SkateboardApp.Views;

namespace SkateboardApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent(); 
		
		Routing.RegisterRoute(nameof(CustomizeView), typeof(CustomizeView));
    }
}
