using System.Windows;
using System.Windows.Threading;

namespace ThreadWPFTest
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Task.Factory.StartNew(ChangeCompanyName);
        }

        private void ChangeCompanyName()
        {
            Thread.Sleep(2500);
            UpdateUIThreadFromAnotherThread();
        }

        private void UpdateUIThreadFromAnotherThread()
        {
            //txtMessage.Text = "123"; excetion

            //Dispatcher.Invoke(() => txtMessage.Text = "234");
            //Dispatcher.BeginInvoke(DispatcherPriority.Normal, (Action)(() => txtMessage.Text = "456"));

            //Application.Current.Dispatcher.BeginInvoke(DispatcherPriority.Normal, (Action)(() => txtMessage.Text = "345"));
        }
    }
}