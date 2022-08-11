using DevExpress.Maui.DataForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAppearance {
    public class EmployeeInfo {
        public string PhotoPath { get; set; }

        [DataFormTextEditor(Placeholder = "First Name")]
        [DataFormDisplayOptions(GroupName = "Name")]
        public string FirstName { get; set; }

        [DataFormTextEditor(Placeholder = "Last Name")]
        [DataFormDisplayOptions(GroupName = "Name")]
        public string LastName { get; set; }

        [DataFormTextEditor(Placeholder = "Email")]
        [DataFormDisplayOptions(GroupName = "Email & Phone")]
        public string Email { get; set; }

        [DataFormMaskedEditor(Mask = "+1 (000) 000-0000", Keyboard = "Telephone", Placeholder = "Phone")]
        [DataFormDisplayOptions(GroupName = "Email & Phone")]
        public string Phone { get; set; }

        [DataFormTextEditor(Placeholder = "Address")]
        [DataFormDisplayOptions(GroupName = "Address")]
        public string Address { get; set; }

        [DataFormTextEditor(Placeholder = "City")]
        [DataFormDisplayOptions(GroupName = "Address")]
        public string City { get; set; }

        [DataFormTextEditor(Placeholder = "State")]
        [DataFormDisplayOptions(GroupName = "Address")]
        public string State { get; set; }

        [DataFormMaskedEditor(Mask = "00000", Keyboard = "Numeric", Placeholder = "Zip")]
        [DataFormDisplayOptions(GroupName = "Address")]
        public string Zip { get; set; }

        [DataFormComboBoxEditor(Placeholder = "Department", IsFilterEnabled = true)]
        [DataFormDisplayOptions(GroupName = "Employment Data")]
        public DepartmentType Department { get; set; } = DepartmentType.Sales;

        [DataFormTextEditor(Placeholder = "Position")]
        [DataFormDisplayOptions(GroupName = "Employment Data")]
        public string Position { get; set; }

        [DataFormDateEditor]
        [DataFormDisplayOptions(GroupName = "Employment Data")]
        public DateTime HiredAt { get; set; } = DateTime.Now;

        [DataFormMultilineEditor(Placeholder = "Notes")]
        [DataFormDisplayOptions(GroupName = "Employment Data")]
        public string Notes { get; set; }
    }

    public enum DepartmentType {
        Sales,
        Support,
        Shipping,
        Engineering,
        Management,
        IT
    }
}
