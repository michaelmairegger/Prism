using System.Threading.Tasks;
using Windows.ApplicationModel.Activation;
using HelloWorld.Services;
using Prism.Unity.Windows;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using HelloWorld.Views;

namespace HelloWorld
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    sealed partial class App : PrismUnityApplication
    {
        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
        {
            this.InitializeComponent();
        }

        protected override UIElement CreateShell(Frame rootFrame)
        {
            rootFrame.Content = new MainPage();
            return rootFrame;
        }

        protected override Task OnLaunchApplicationAsync(LaunchActivatedEventArgs args)
        {
            return Task.FromResult<object>(null);
        }

        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();

            RegisterTypeIfMissing(typeof(IDataRepository), typeof(DataRepository), true);
        }
    }
}
