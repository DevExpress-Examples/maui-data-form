using DevExpress.Maui.DataForm;

namespace DataFormGetStarted
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            dataform.DataObject = new PersonalInfo();
        }

    }
}