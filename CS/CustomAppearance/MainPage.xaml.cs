namespace CustomAppearance {
    public partial class MainPage : ContentPage {
        EmployeeRepository repository = new EmployeeRepository();
        public MainPage() {
            InitializeComponent();
            dataForm.DataObject = repository.Get(0);
        }
    }
}