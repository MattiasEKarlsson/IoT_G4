using Microsoft.Azure.Devices.Client;
using Test_33.Services;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;



namespace Test_33
{


    public sealed partial class MainPage : Page
    {
        
        public MainPage()
        {
            this.InitializeComponent();
        }
        private static readonly string _conn = "HostName=ec-win20iothub.azure-devices.net;DeviceId=DeviceApp;SharedAccessKey=sJGB59/d4EwPyNVxsX/VXWzxQoZkivpeYQUN+Bu7j+k=";
        private static readonly DeviceClient deviceClient = DeviceClient.CreateFromConnectionString(_conn, TransportType.Mqtt);

        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
            DeviceService.SendMessageAsync(deviceClient).GetAwaiter();
        }
    }
}
