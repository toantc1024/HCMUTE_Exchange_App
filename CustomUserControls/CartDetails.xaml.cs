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
    /// Interaction logic for CartDetails.xaml
    /// </summary>
    public partial class CartDetails : UserControl
    {
        public CartDetails()
        {
            InitializeComponent();
        }

        // register the dependency property
        public static readonly DependencyProperty CartItemsProperty = DependencyProperty.Register("CartItems", typeof(object), typeof(CartDetails), new PropertyMetadata(null));
        public object CartItems
        {
            get { return GetValue(CartItemsProperty); }
            set { SetValue(CartItemsProperty, value); }
        }



        // change view command  
        public static readonly DependencyProperty ChangeViewCommandProperty = DependencyProperty.Register("ChangeViewCommand", typeof(ICommand), typeof(CartDetails), new PropertyMetadata(null));

        public ICommand ChangeViewCommand
        {
            get { return (ICommand)GetValue(ChangeViewCommandProperty); }
            set { SetValue(ChangeViewCommandProperty, value); }
        }
    }
}
