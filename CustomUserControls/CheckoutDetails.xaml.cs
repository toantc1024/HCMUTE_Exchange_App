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

namespace Exchange_App.CustomUserControls
{
    /// <summary>
    /// Interaction logic for CheckoutDetails.xaml
    /// </summary>
    public partial class CheckoutDetails : UserControl
    {
        public CheckoutDetails()
        {
            InitializeComponent();
        }

        // order command

        public static readonly DependencyProperty OrderCommandProperty = DependencyProperty.Register("OrderCommand", typeof(ICommand), typeof(CheckoutDetails), new PropertyMetadata(null));
        public ICommand OrderCommand
        {
            get { return (ICommand)GetValue(OrderCommandProperty); }
            set { SetValue(OrderCommandProperty, value); }
        }

        // change view command
        public static readonly DependencyProperty ChangeViewCommandProperty = DependencyProperty.Register("ChangeViewCommand", typeof(ICommand), typeof(CheckoutDetails), new PropertyMetadata(null));

        public ICommand ChangeViewCommand
        {
            get { return (ICommand)GetValue(ChangeViewCommandProperty); }
            set { SetValue(ChangeViewCommandProperty, value); }
        }
    }
}
