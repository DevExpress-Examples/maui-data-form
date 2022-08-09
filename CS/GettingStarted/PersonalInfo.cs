using System;
using DevExpress.Maui.DataForm;

namespace DataForm_GettingStarted {
    public class PersonalInfo
    {
        [DataFormItemPosition(RowOrder = 1, ItemOrderInRow = 1)]
        [DataFormDisplayOptions(LabelIcon = "name", GroupName = "Profile")]
        public string FirstName { get; set; }

        [DataFormItemPosition(RowOrder = 1, ItemOrderInRow = 2)]
        [DataFormDisplayOptions(IsLabelVisible = false, GroupName = "Profile")]
        public string LastName { get; set; }

        [DataFormDisplayOptions(LabelIcon = "birthdate", GroupName = "Profile")]
        public DateTime? BirthDate { get; set; }

        [DataFormDisplayOptions(IsVisible = false)]
        public virtual Gender Gender { get; set; }

        [DataFormPasswordEditor]
        [DataFormDisplayOptions(LabelIcon = "password", GroupName = "Profile")]
        public string Password { get; set; }

        [DataFormDisplayOptions(LabelIcon = "email", GroupName = "Contact Info")]
        public string Email { get; set; }

        [DataFormMaskedEditor(Mask = "(000) 000-0000", Keyboard = "Telephone")]
        [DataFormDisplayOptions(LabelIcon = "phone", GroupName = "Contact Info")]
        public string Phone { get; set; }
    }
    public enum Gender { Female, Male, RatherNotSay }
}
