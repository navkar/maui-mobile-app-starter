namespace AppFinder.View.Shell;

public partial class FlyoutHeader : ContentView
{
	public FlyoutHeader()
	{
		InitializeComponent();
		BindingContext = new AppInfoViewModel();
	}
}
