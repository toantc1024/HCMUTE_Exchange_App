using Exchange_App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Exchange_App.ViewModel
{
    public class CheckoutViewModel : BaseViewModel
    {

        private string _showCheckout;
        private User _currentUser;
        private List<object> _cartItems;

        public ICommand ChangeViewCommand { get; set; }
        public ICommand OrderCommand { get; set; }

        public CheckoutViewModel(User user)
        {
            CurrentUser = user;
            ChangeView("Cart");
            var custQuery = from cart in CurrentUser.CartItems
                            join product in DataProvider.Ins.DB.Products
                            on cart.ProductID equals product.ProductID
                            select new
                            {
                                ProductID = product.ProductID,
                                Original_price = product.Original_price,
                                Sell_price = product.Sell_price,
                                ProductName = product.ProductName,
                                PreviewImage = product.GetPreviewImage,
                                Category = product.Category,
                                Product_Quantity = product.Quantity,
                                CartItemsID = cart.CartItemsID,
                                CartQuantity = cart.Quantity,
                                Total = product.Sell_price * cart.Quantity
                            };
            CartItems = custQuery.ToList<object>();
            ChangeViewCommand = new RelayCommand<string>(
                (p) => { return true; },
                (p) => {
                    ChangeView(p);
                }
             );

            OrderCommand = new RelayCommand<object>(
               (p) => { return true; },
                (p) => {

                    MessageBox.Show("Order has been placed " + CurrentUser.Username);
                }
            );
        }


        public void ChangeView(string view)
        {
            if(view == "Checkout")
            {
                ShowCheckout = "Visible";
            } else
            {
                ShowCheckout = "Hidden";
            }
        }

        public User CurrentUser { get => _currentUser; set => _currentUser=value; }
        public List<object> CartItems { get => _cartItems; set => _cartItems=value; }
        public string ShowCheckout { get => _showCheckout; set { _showCheckout=value; OnPropertyChanged(); } }
    }
}
