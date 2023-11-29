# DataFormView for .NET MAUI - Edit a Contact’s Data

This example demonstrates how to use the [`DataFormView`](https://docs.devexpress.com/MAUI/DevExpress.Maui.DataForm.DataFormView) control to implement a contact edit form. To edit the user avatar, you can use the [`ImageEdit`](https://docs.devexpress.com/MAUI/DevExpress.Maui.Editors.ImageEdit) control. 

<img src="../../Images/data-form-with-image-edit-upload.png" alt="DevExpress Data Form for iOS" height="700"/> <img src="../../Images/data-form-with-image-edit-bs.png" alt="DevExpress Data Form for Android" height="700"/>

## Implementation Details

* Specify the [`DataFormView.DataObject`](https://docs.devexpress.com/MAUI/DevExpress.Maui.DataForm.DataFormView.DataObject) property to bind a `DataFormView` to an object.
  
* Use a `DataFormView` editor's [`FieldName`](https://docs.devexpress.com/MAUI/DevExpress.Maui.DataForm.DataFormItem.FieldName) property to bind the editor to a view model's property:

    ```xml
    <dxdf:DataFormTextItem FieldName="FirstName" .../>
    ```

* Call the [`DataFormView.Commit`](https://docs.devexpress.com/MAUI/DevExpress.Maui.DataForm.DataFormView.Commit) method to validate input values and send changes to the data source. 

* `DataFormView` supports validation events and attributes. The following code uses a validation event for `Email` values:

    ```csharp
    private void ValidateCustomerProperties(object sender, DevExpress.Maui.DataForm.DataFormPropertyValidationEventArgs e) {
        if (e.PropertyName == "Email" && e.NewValue != null) {
            MailAddress res;
            if (!MailAddress.TryCreate((string)e.NewValue, out res)) {
                e.HasError = true;
                e.ErrorText = "Invalid email";
            }
        }
    }
    ```

    The following code snippet defines validation attributes for `FirstName` and `LastName` properties:

    ```csharp
    public class Customer {

    [Required(ErrorMessage = "First Name cannot be empty")]
    public string FirstName 
        //...
    [Required(ErrorMessage = "Last Name cannot be empty")]
    public string LastName 
        //...
    }
    ```

* `DataFormView` automatically aligns its editors. You can customize the color and width of editor labels:

    ```xaml
    <dxdf:DataFormView EditorLabelColor="{StaticResource Primary}" EditorLabelWidth="40">
    ```

* Embedded `DataFormView`'s editors contain customization options such as [`LabelIcon`](https://docs.devexpress.com/MAUI/DevExpress.Maui.DataForm.DataFormItem.LabelIcon), [`InplaceLabelText`](https://docs.devexpress.com/MAUI/DevExpress.Maui.DataForm.DataFormItem.InplaceLabelText), [`LabelText`](https://docs.devexpress.com/MAUI/DevExpress.Maui.DataForm.DataFormItem.LabelText), and [`IsInplaceLabelFloating`](https://docs.devexpress.com/MAUI/DevExpress.Maui.Editors.EditBase.IsLabelFloating).

* You can use the `LabelIcon` property to divide editors into visual groups.

    ```xml
    <dxdf:DataFormView ...>
        <dxdf:DataFormTextItem FieldName="FirstName" LabelIcon="editorsname" .../>
        <dxdf:DataFormTextItem FieldName="LastName" .../>
    </dxdf:DataFormView>
    ```

* If an editor's `LabelIcon` property is not specified, `DataFormView` displays the bound property's name in the editor's label area. You can set the editor's `LabelIcon` property to an empty string to hide this text.

    ```xml
    <dxdf:DataFormTextItem FieldName="LastName" LabelText="" InplaceLabelText="Last Name" .../>
    ```
    
* `DataFormView` items support masks. Specify the [`DataFormMaskedItem.Mask`](https://docs.devexpress.com/MAUI/DevExpress.Maui.DataForm.DataFormMaskedItem.Mask) property to define a mask. 

    ```xml
    <dxdf:DataFormMaskedItem Mask="+1 (000) 000-0000" />
    ```
* Specify a [`DataFormItem`](https://docs.devexpress.com/MAUI/DevExpress.Maui.DataForm.DataFormItem)'s [`Keyboard`](https://docs.devexpress.com/MAUI/DevExpress.Maui.DataForm.DataFormTextItemBase.Keyboard) property to define a type of keyboard used to input text.

## Files to Look At

<!-- default file list -->
* [MainPage.xaml](CS/MainPage.xaml)
* [MainPage.xaml.cs](CS/MainPage.xaml.cs)
* [MainViewModel.cs](CS/MainViewModel.cs)
* [App.xaml](CS/App.xaml)
<!-- default file list end -->

## Documentation

* [DataFormView](https://docs.devexpress.com/MAUI/DevExpress.Maui.DataForm.DataFormView)
* [StatusBarBehavior](https://learn.microsoft.com/en-us/dotnet/communitytoolkit/maui/behaviors/statusbar-behavior)
* [ImageEdit](https://docs.devexpress.com/MAUI/DevExpress.Maui.Editors.ImageEdit)
* [DXBorder](https://docs.devexpress.com/MAUI/DevExpress.Maui.Core.DXBorder)

## More Examples

* [Get Started with DevExpress Data Form for .NET MAUI](../DataFormGetStarted)
* [Add and Remove DataFormItems at Runtime](../AddingDataEditorsAtRuntime)
* [Customize a DataFrom Appearance](../CustomAppearance)
* [Display a ComboBoxEdit in the DataForm](../ComboBoxEditor)
