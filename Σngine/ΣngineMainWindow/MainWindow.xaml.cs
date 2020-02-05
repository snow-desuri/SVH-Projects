using System.Windows;
using System.Windows.Controls;


namespace ΣngineMainWindow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }
        #region Button Logic
        private void contacts_Click(object sender, RoutedEventArgs e)
        {
            contactlisting.Visibility = Visibility.Visible;
            addcontactbutton.Visibility = Visibility.Visible;

        }

        private void members_Click(object sender, RoutedEventArgs e)
        {

        }

        private void briefs_Click(object sender, RoutedEventArgs e)
        {
            contactlisting.Visibility = Visibility.Hidden;
            addcontactbutton.Visibility = Visibility.Hidden;
            contactname.Visibility = Visibility.Hidden;
            rsihandle.Visibility = Visibility.Hidden;
        }

    
        private void investments_Click(object sender, RoutedEventArgs e)
        {

        }

        private void sync_Click(object sender, RoutedEventArgs e)
        {

        }

        private void addcontactbutton_Click(object sender, RoutedEventArgs e)
        {
            contactname.Visibility = Visibility.Visible;
            rsihandle.Visibility = Visibility.Visible;
        }
        

        private void contactname_GotFocus(object sender, RoutedEventArgs e)
        {            
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= contactname_GotFocus;           
        }

        private void rsihandle_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= rsihandle_GotFocus;

        }
        #endregion
    }

}
