using System.Net.Mail;
using System.Runtime.CompilerServices;

namespace EditFormExample {
    public partial class MainPage : ContentPage {
        public MainPage() {
            InitializeComponent();
        }
        private void ValidateCustomerProperties(object sender, DevExpress.Maui.DataForm.DataFormPropertyValidationEventArgs e) {
            if (e.PropertyName == "Email" && e.NewValue != null) {
                MailAddress res;
                if (!MailAddress.TryCreate((string)e.NewValue, out res)) {
                    e.HasError = true;
                    e.ErrorText = "Invalid email";
                }
            }
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e) {
            dataForm.Commit();
        }
    }
}