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

namespace Lab1_BirthDateWindow.Views
{
    /// <summary>
    /// Interaction logic for BirthDateControl.xaml
    /// </summary>
    public partial class BirthDateControl : UserControl
    {
        public BirthDateControl()
        {
            InitializeComponent();
        }

        private void Label_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ((Label)sender).Visibility = Visibility.Collapsed;
        }
    }
}
