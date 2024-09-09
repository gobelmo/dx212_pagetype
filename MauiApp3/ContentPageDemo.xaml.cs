namespace MauiApp3;

public partial class ContentPageDemo : ContentPage
{
	public ContentPageDemo()
	{
		InitializeComponent();
	}

	private void OnNavigateBtnClicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new FlyoutPageDemo());
	}
}