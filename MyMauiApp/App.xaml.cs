namespace MyMauiApp;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        // When the app is forced to use a specific theme, e.g. Dark
        // The OS components like keyboard, timepicker, etc. will use theme of the OS.
        // I would expect the OS component to use the theme of the app.
        UserAppTheme = AppTheme.Dark;

        MainPage = new AppShell();
    }
}
