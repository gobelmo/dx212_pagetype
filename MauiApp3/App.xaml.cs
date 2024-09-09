namespace MauiApp3;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		//MainPage = new AppShell();
		//MainPage = new Demo();
		//MainPage = new ContentPageDemo();
		//MainPage = new FlyoutPageDemo();
		//MainPage = new TabbedPageDemo();
		MainPage = new NavigationPage(new MainPage());

	}
}
