namespace AppFinder.View.Shell;

public partial class FlyoutFooter : ContentView
{
	public FlyoutFooter()
	{
		InitializeComponent();
		BindingContext = new AppInfoViewModel();
	}
}
