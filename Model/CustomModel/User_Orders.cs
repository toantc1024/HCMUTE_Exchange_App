using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange_App.Model.CustomModel
{
    public class User_Orders : User_Order
    {
        private string _total;



        public User_Orders()
        {
        }

        public string Total
        {
            get
            {
                return OrderDetails.Aggregate(0.0, (acc, item) => acc + item.Product.Sell_price * item.Quantity).ToString();
            }
            set {; }
        }
    }
}
