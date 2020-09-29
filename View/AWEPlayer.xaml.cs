using AWEVideoPlayer.ModelView;
using AWEVideoPlayer.ModelView.APIHELPER;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Shapes;

namespace AWEVideoPlayer.View
{
    /// <summary>
    /// Interaction logic for AWEPlayer.xaml
    /// </summary>
    public partial class AWEPlayer : Window
    {
        public AWEPlayer()
        {

            InitializeComponent();

        }

        private void Hyperlink_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {

                Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
                e.Handled = true;
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            
        }
    }
}
