using System;
using System.Globalization;
using System.Threading.Tasks;
using DevExpress.Maui.Editors;
using Microsoft.Maui.Controls;

namespace EditFormExample;

public partial class ImageEditView : ContentPage {
    private TaskCompletionSource<ImageSource> pageResultCompletionSource;

    public ImageEditView() {
        InitializeComponent();
    }

    public ImageEditView(ImageSource imageSource) {
        InitializeComponent();
        pageResultCompletionSource = new TaskCompletionSource<ImageSource>();
        editor.Source = imageSource;
    }

    public Task<ImageSource> WaitForResultAsync() {
        return pageResultCompletionSource.Task;
    }

    private async void BackPressed(object sender, EventArgs e) {
        pageResultCompletionSource.SetResult(null);
        await Navigation.PopAsync();
    }

    private async void CropPressed(object sender, EventArgs e) {
        pageResultCompletionSource.SetResult(editor.SaveAsImageSource(DevExpress.Maui.Editors.ImageFormat.Jpeg));
        await Navigation.PopAsync();
    }
}

public class FrameTypeToImageStringConverter : IValueConverter {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
        return (CropAreaShape)value == CropAreaShape.Ellipse ? "ic_frame_rect" : "ic_frame_circle";
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
        throw new NotImplementedException();
    }
}