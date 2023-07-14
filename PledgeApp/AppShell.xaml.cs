namespace PledgeApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute(nameof(Views.ImagesPage), typeof(Views.ImagesPage));
    }
}
