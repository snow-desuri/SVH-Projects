using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
