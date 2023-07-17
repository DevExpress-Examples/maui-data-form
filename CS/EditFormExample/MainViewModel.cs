using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EditFormExample {
    public class MainViewModel : BindableBase {
        Customer editedItem;
        public Customer EditedItem {
            get { return editedItem; }
            set {
                editedItem = value;
                RaisePropertyChanged();
            }
        }
        public MainViewModel() {
            EditedItem = new Customer() { FirstName = "Jennie", LastName= "Valentine", Company= "Valentine Hearts", City= "Johnsonville", State= "NY", Address= "9333 Holmes Dr.", ZipCode= 12121, Email= "jennie.valentine@valetinehearts.com", Phone= "(898)745-1511", PhotoPath= "jennie_photo" };
        }
    }
}
