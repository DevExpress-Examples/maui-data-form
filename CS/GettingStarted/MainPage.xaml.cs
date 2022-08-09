using DevExpress.Maui.DataForm;
namespace DataForm_GettingStarted;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        dataForm.DataObject = new PersonalInfo();
    }

    void dataForm_ValidateProperty(System.Object sender, DataFormPropertyValidationEventArgs e)
    {
        if (e.PropertyName == "Password")
        {
            if (e.NewValue.ToString().Length < 6)
            {
                e.HasError = true;
                e.ErrorText = "The password should contain more than 5 characters.";
            }
        }
    }
}


