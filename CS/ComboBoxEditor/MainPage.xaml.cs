using DevExpress.Maui.DataForm;
using System.Collections;

namespace ComboBoxEditor {
    public class DepartmentInfo {
        public int DepartmentCode { get; set; }
        public string DepartmentName { get; set; }

        public DepartmentInfo(int code, string name) {
            DepartmentCode = code;
            DepartmentName = name;
        }
    }

    public class EmployeeInfo {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [DataFormComboBoxEditor(ValueMember = "DepartmentCode", DisplayMember = "DepartmentName")]
        public int Department { get; set; }

        [DataFormComboBoxEditor]
        public string Status { get; set; }
    }

    public class ComboBoxDataProvider : IPickerSourceProvider {
        public IEnumerable GetSource(string propertyName) {
            if (propertyName == "Department") {
                return new List<DepartmentInfo>() {
                    new DepartmentInfo(0, "Sales"),
                    new DepartmentInfo(1, "Support"),
                    new DepartmentInfo(2, "Shipping"),
                    new DepartmentInfo(3, "Engineering"),
                    new DepartmentInfo(4, "Human Resources"),
                    new DepartmentInfo(5, "Management"),
                    new DepartmentInfo(6, "IT")
                };
            }
            if (propertyName == "Status") {
                return new List<string>() {
                    "Salaried",
                    "Commission",
                    "Terminated",
                    "On Leave"
                };
            }
            return null;
        }
    }
    public partial class MainPage : ContentPage {

        public MainPage() {
            InitializeComponent();
            dataForm.DataObject = new EmployeeInfo();
            dataForm.PickerSourceProvider = new ComboBoxDataProvider();
        }
    }
}