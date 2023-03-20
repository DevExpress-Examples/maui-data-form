using System.Collections.Generic;
using DevExpress.Maui.DataForm;

namespace AddingDataEditorsAtRuntime {
    public partial class MainPage : ContentPage {
        Dictionary<string, object> dataModel = new Dictionary<string, object>();
        public MainPage() {
            InitializeComponent();
            dataForm.IsAutoGenerationEnabled = false;
            dataForm.CommitMode = CommitMode.Input;
            dataForm.DataObject = dataModel;
        }

        public static string[] Emails = { "ameliah@dx-email.com",
                                          "anthonys@dx-email.com",
                                          "arnolds@dx-email.com",
                                          "arthurm@dx-email.com" };

        private void Add_Editor(object sender, EventArgs e) {
            string editorName = $"Email {dataModel.Count}";
            Random random = new Random();

            int mailindex = random.Next(1, Emails.Length);
            object editorValue = Emails[mailindex];

            var dataformItem = new DataFormTextItem { FieldName = editorName };

            dataModel.Add(dataformItem.FieldName, editorValue);
            dataForm.Items.Add(dataformItem);
        }

        private void Remove_Editor(object sender, EventArgs e) {
            if (dataForm.Items.Count > 0) {
                dataModel.Remove(dataModel.Last().Key);
                dataForm.Items.RemoveAt(dataForm.Items.Count - 1);
            }
        }
    }
}