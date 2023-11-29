# DataFormView for .NET MAUI - Edit a Contact’s Data

This example demonstrates how to use a [DataFormView](https://docs.devexpress.com/MAUI/DevExpress.Maui.DataForm.DataFormView) to implement a contact edit form.  

<img src="https://user-images.githubusercontent.com/12169834/228216536-48240713-be2f-45e7-9dda-dbf843682500.png" width="30%"/>

Included controls and their properties:

* [DataFormView](https://docs.devexpress.com/MAUI/DevExpress.Maui.DataForm.DataFormView): [ValidateProperty](https://docs.devexpress.com/MAUI/DevExpress.Maui.DataForm.DataFormView.ValidateProperty), [DataObject](https://docs.devexpress.com/MAUI/DevExpress.Maui.DataForm.DataFormView.DataObject)

* [StatusBarBehavior](https://learn.microsoft.com/en-us/dotnet/communitytoolkit/maui/behaviors/statusbar-behavior): [StatusBarColor](https://learn.microsoft.com/en-us/dotnet/communitytoolkit/maui/behaviors/statusbar-behavior?tabs=ios#using-the-statusbarbehavior), [StatusBarStyle](https://learn.microsoft.com/en-us/dotnet/communitytoolkit/maui/behaviors/statusbar-behavior?tabs=ios#using-the-statusbarbehavior)


## Implementation Details


* To bind a DataFormView to an object, specify the [DataFormView.DataObject](https://docs.devexpress.com/MAUI/DevExpress.Maui.DataForm.DataFormView.DataObject) property.
  
* Specify a [DataFormView](https://docs.devexpress.com/MAUI/DevExpress.Maui.DataForm.DataFormView) editor's [FieldName](https://docs.devexpress.com/MAUI/DevExpress.Maui.DataForm.DataFormItem.FieldName) property to bind the editor to a view model's property:

    ```xml
    <dxdf:DataFormTextItem FieldName="FirstName" .../>
    ```

    File to Look At: [MainPage.xaml](MainPage.xaml)

* Call the [DataFormView.Commit](https://docs.devexpress.com/MAUI/DevExpress.Maui.DataForm.DataFormView.Commit) method to validate input values and send changes to the data source. 

* [DataFormView](https://docs.devexpress.com/MAUI/DevExpress.Maui.DataForm.DataFormView) supports validation events and attributes. The following code uses a validation event for `Email` values:

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

    File to Look At: [MainPage.xaml.cs](MainPage.xaml.cs)

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

    File to Look At: [MainPage.xaml](MainPage.xaml)

* [DataFormView](https://docs.devexpress.com/MAUI/DevExpress.Maui.DataForm.DataFormView) automatically aligns its editors. You can customize the color and width of editor labels:

    ```xaml
    <dxdf:DataFormView EditorLabelColor="{StaticResource Primary}" EditorLabelWidth="40">
    ```

    File to Look At: [MainPage.xaml](MainPage.xaml)

* Embedded [DataFormView](https://docs.devexpress.com/MAUI/DevExpress.Maui.DataForm.DataFormView)'s editors contain customization options such as [LabelIcon](https://docs.devexpress.com/MAUI/DevExpress.Maui.DataForm.DataFormItem.LabelIcon), [InplaceLabelText](https://docs.devexpress.com/MAUI/DevExpress.Maui.DataForm.DataFormItem.InplaceLabelText), [LabelText](https://docs.devexpress.com/MAUI/DevExpress.Maui.DataForm.DataFormItem.LabelText), and [IsInplaceLabelFloating](https://docs.devexpress.com/MAUI/DevExpress.Maui.Editors.EditBase.IsLabelFloating).

* You can use the [LabelIcon](https://docs.devexpress.com/MAUI/DevExpress.Maui.DataForm.DataFormItem.LabelIcon) property to divide editors into visual groups. To do this, specify the [LabelIcon](https://docs.devexpress.com/MAUI/DevExpress.Maui.DataForm.DataFormItem.LabelIcon) property of the first editor in a group.


    ```xml
    <dxdf:DataFormView ...>
        <dxdf:DataFormTextItem FieldName="FirstName" LabelIcon="editorsname" .../>
        <dxdf:DataFormTextItem FieldName="LastName" .../>
    </dxdf:DataFormView>
    ```

    File to Look At: [MainPage.xaml](MainPage.xaml)

* If an editor's [LabelIcon](https://docs.devexpress.com/MAUI/DevExpress.Maui.DataForm.DataFormItem.LabelIcon) property is not specified, [DataFormView](https://docs.devexpress.com/MAUI/DevExpress.Maui.DataForm.DataFormView) displays the bound property's name in the editor's label area. You can set the editor's [LabelIcon](https://docs.devexpress.com/MAUI/DevExpress.Maui.DataForm.DataFormItem.LabelIcon) property to an empty string to hide this text.

    ```xml
    <dxdf:DataFormTextItem FieldName="LastName" LabelText="" InplaceLabelText="Last Name" .../>
    ```
    
* [DataFormView](https://docs.devexpress.com/MAUI/DevExpress.Maui.DataForm.DataFormView) items support masks. Specify the [DataFormMaskedItem.Mask](https://docs.devexpress.com/MAUI/DevExpress.Maui.DataForm.DataFormMaskedItem.Mask) property to define a mask. 

    ```xml
    <dxdf:DataFormMaskedItem Mask="+1 (000) 000-0000" />
    ```
* Specify a [DataFormItem](https://docs.devexpress.com/MAUI/DevExpress.Maui.DataForm.DataFormItem)'s [Keyboard](https://docs.devexpress.com/MAUI/DevExpress.Maui.DataForm.DataFormTextItemBase.Keyboard) property to define a type of keyboard used to input text.

## Files to Look At

<!-- default file list -->
* [MainPage.xaml](MainPage.xaml)
* [MainPage.xaml.cs](MainPage.xaml.cs)
* [MainViewModel.cs](MainViewModel.cs)
* [App.xaml](App.xaml)
<!-- default file list end -->

## Documentation

* [Featured Scenario: Context Menu Actions in Popup](https://docs.devexpress.com/MAUI/404342)
* [Featured Scenarios](https://docs.devexpress.com/MAUI/404291)
* [SimpleButton.Content](https://docs.devexpress.com/MAUI/DevExpress.Maui.Controls.SimpleButton.Content)
* [DXPopup](https://docs.devexpress.com/MAUI/DevExpress.Maui.Controls.DXPopup)

## More Examples

* [DevExpress Mobile UI for .NET MAUI](https://github.com/DevExpress-Examples/maui-demo-app/)
