using Exchange_App.Model;
using Exchange_App.Model.CustomModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Exchange_App.ViewModel
{
    public class UserViewModel : BaseViewModel
    {

        private string _name;
        private DateTime _dateOfBirth;
        private User _currentUser;
        private ICollection<User_Orders> _orders;

        public UserViewModel(User user)
        {
            CurrentUser = user;
            
            Name = CurrentUser.Name;
            DateOfBirth = CurrentUser.Birthdate;
            MessageBox.Show(DateOfBirth.ToString());   
        }

        public User CurrentUser { get => _currentUser; set => _currentUser=value; }
        public string Name { get => _name; set => _name=value; }
        public DateTime DateOfBirth { get => _dateOfBirth; set => _dateOfBirth=value; }
        public ICollection<User_Orders> Orders { get => _orders; set => _orders=value; }
    }
}
