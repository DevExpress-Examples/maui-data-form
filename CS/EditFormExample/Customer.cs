using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace EditFormExample {
    [Table("Customers")]
    public class Customer : BindableBase {
        int? id;
        string firstName;
        string lastName;
        string company;
        string address;
        string city;
        string state;
        string email;
        int zipcode;
        string phone;
        string photoPath;


        public int? ID {
            get {
                return id;
            }
            set {
                id = value;
                RaisePropertyChanged();
            }
        }

        [Required(ErrorMessage = "First Name cannot be empty")]
        public string FirstName {
            get {
                return firstName;
            }
            set {
                firstName = value;
                RaisePropertyChanged();
            }
        }
        [Required(ErrorMessage = "Last Name cannot be empty")]
        public string LastName {
            get {
                return lastName;
            }
            set {
                lastName = value;
                RaisePropertyChanged();
            }
        }
        public string Company {
            get {
                return company;
            }
            set {
                company = value;
                RaisePropertyChanged();
            }
        }
        public string Address {
            get {
                return address;
            }
            set {
                address = value;
                RaisePropertyChanged();
            }
        }
        public string City {
            get {
                return city;
            }
            set {
                city = value;
                RaisePropertyChanged();
            }
        }
        public string State {
            get {
                return state;
            }
            set {
                state = value;
                RaisePropertyChanged();
            }
        }
        public int ZipCode {
            get {
                return zipcode;
            }
            set {
                zipcode = value;
                RaisePropertyChanged();
            }
        }
        public string Phone {
            get {
                return phone;
            }
            set {
                phone = value;
                RaisePropertyChanged();
            }
        }

        public string Email {
            get {
                return email;
            }
            set {
                email = value;
                RaisePropertyChanged();
            }
        }

        public string PhotoPath {
            get {
                return photoPath;
            }
            set {
                photoPath = value;
                RaisePropertyChanged();
            }
        }
    }
    public class BindableBase : INotifyPropertyChanged {
        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged([CallerMemberName] string propertyName = "") {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
