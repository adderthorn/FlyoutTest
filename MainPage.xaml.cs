using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Storage;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace FlyoutTesting
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void EditBox_Loaded(object sender, RoutedEventArgs e)
        {
            var lipsumFile = await StorageFile.GetFileFromApplicationUriAsync(new Uri("ms-appx:///Resources/Lipsum.txt"));
            using (var reader = new StreamReader(await lipsumFile.OpenStreamForReadAsync()))
            {
                EditBox.Document.SetText(Windows.UI.Text.TextSetOptions.None, await reader.ReadToEndAsync());
            }
        }
    }
}
