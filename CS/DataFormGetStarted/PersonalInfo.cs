using DevExpress.Maui.DataForm;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFormGetStarted
{
    public class PersonalInfo
    {
        [DataFormItemPosition(RowOrder = 1, ItemOrderInRow = 1)]
        [DataFormTextEditor(InplaceLabelText = "First Name")]
        [DataFormDisplayOptions(LabelIcon = "name", GroupName = "Profile")]
        public string FirstName { get; set; }

        [DataFormItemPosition(RowOrder = 1, ItemOrderInRow = 2)]
        [DataFormTextEditor(InplaceLabelText = "Last Name")]
        [DataFormDisplayOptions(IsLabelVisible = false, GroupName = "Profile")]
        public string LastName { get; set; }

        [DataFormDisplayOptions(GroupName = "Profile")]
        public DateTime? BirthDate { get; set; }

        [DataFormDisplayOptions(GroupName = "Profile")]
        public virtual Gender Gender { get; set; }

        [DataFormPasswordEditor]
        [DataFormDisplayOptions(GroupName = "Profile")]
        [StringLength(64, MinimumLength = 8,
            ErrorMessage = "The password should contain at least 8 characters.")]
        [Required(ErrorMessage = "Required")]
        public string Password { get; set; }

        [DataFormDisplayOptions(GroupName = "Contact Info")]
        public string Email { get; set; }

        [DataFormMaskedEditor(Mask = "+0 (000) 000-0000", Keyboard = "Telephone")]
        [DataFormDisplayOptions(GroupName = "Contact Info")]
        [DataFormItemPosition(RowOrder = 1)]
        public string Phone { get; set; }

        [DataFormDisplayOptions(LabelText = "Subscribe to Newsletters", LabelMinWidth = 200, GroupName = "Contact Info")]
        public bool Newsletters { get; set; }
    }
    public enum Gender { Female, Male, RatherNotSay }
}