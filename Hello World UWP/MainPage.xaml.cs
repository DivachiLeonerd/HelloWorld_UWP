using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Hello_World_UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private Random rand;
        public MainPage()
        {
            this.InitializeComponent();
            rand = new Random();
        }
        private byte[] GetRandomBytes(int n)
        {
            // Fill an array of bytes of length "n" with random numbers.
            var randomBytes = new byte[n];
            rand.NextBytes(randomBytes);
            return randomBytes;
        }
        private void SayHelloButtonClick(object sender, RoutedEventArgs e)
        {
            byte[] rgb = GetRandomBytes(3);

            // Create a solid color brush using the three random numbers.
            var randomColorBrush = new SolidColorBrush(Windows.UI.Color.FromArgb(255, rgb[0], rgb[1], rgb[2]));

            // Set both the text color and the text box border to the random color.
            helloWorldTextBox.Text = "Hello There!";
            helloWorldTextBox.BorderBrush = randomColorBrush;
            helloWorldTextBox.Foreground = randomColorBrush;
        }
    }
}
