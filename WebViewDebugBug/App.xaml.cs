using System.Diagnostics;

namespace WebViewDebugBug
{
    public partial class App : Application
    {
        public App() {

            IDispatcherTimer timer = Application.Current.Dispatcher.CreateTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += delegate {
                Debug.WriteLine("SECOND PASSED: " + DateTime.UtcNow.Second);
            };
            Debug.WriteLine("START TIMER");
            timer.Start();

            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}