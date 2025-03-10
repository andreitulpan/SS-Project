using MQTTnet;

namespace ImageProcessingBackend.Services
{
    public class MqttService : IHostedService
    {
        private readonly IMqttClient _mqttClient;
        private readonly string _brokerAddress;
        private readonly string _topic;
        private readonly string _imageStoragePath = "Images";

        public MqttService(IConfiguration configuration)
        {
            _brokerAddress = configuration["Mqtt:Broker"];
            _topic = configuration["Mqtt:Topic"];

            //var factory = new MqttFactory();
            //_mqttClient = factory.CreateMqttClient();
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            //var options = new MqttClientOptionsBuilder()
            //    .WithTcpServer(_brokerAddress)
            //    .Build();

            //_mqttClient.ApplicationMessageReceivedAsync += async e =>
            //{
            //    string deviceId = e.ApplicationMessage.Topic.Split('/')[1];
            //    string fileName = $"{deviceId}_{DateTime.UtcNow:yyyyMMddHHmmss}.jpg";
            //    string filePath = Path.Combine(_imageStoragePath, fileName);

            //    Directory.CreateDirectory(_imageStoragePath);
            //    //await File.WriteAllBytesAsync(filePath, e.ApplicationMessage.PayloadSegment.ToArray());

            //    Console.WriteLine($"Received image from {deviceId}, saved to {filePath}");
            //};

            //await _mqttClient.ConnectAsync(options, cancellationToken);
            //await _mqttClient.SubscribeAsync(_topic);
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
            await _mqttClient.DisconnectAsync();
        }
    }
}