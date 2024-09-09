namespace MauiApp3;

public partial class FlyoutPageDemo : FlyoutPage
{
	public FlyoutPageDemo()
	{
		InitializeComponent();
	}

	private void OnNavigateBtnClicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new TabbedPageDemo());
	}
}