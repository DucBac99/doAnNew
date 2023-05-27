using System.Text;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
namespace doAnNew
{
    public partial class Form1 : Form
    {
        private MqttClient mqttClient;
        private string mqttEndpoint = "ai3594tsfjxzr-ats.iot.ap-southeast-2.amazonaws.com";
        private string mqttTopic = "board";
        private bool isConnected = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            InitializeMqttClient();
        }

        private void InitializeMqttClient()
        {
            mqttClient = new MqttClient(mqttEndpoint);

            // Set up TLS/SSL connection using certificate files
            string certFilePath = @"D:\dATN\aws_document\c57ac2977f45e397813ee384a76d413a5bb1fa9d058a0b1ae71318ad47fa3024-certificate.pem.crt";
            string keyFilePath = @"D:\dATN\aws_document\c57ac2977f45e397813ee384a76d413a5bb1fa9d058a0b1ae71318ad47fa3024-private.pem.key";
            string caFilePath = @"D:\dATN\aws_document\AmazonRootCA1.pem";

            mqttClient.MqttMsgPublishReceived += MqttClient_MqttMsgPublishReceived;

            mqttClient.ConnectionClosed += MqttClient_ConnectionClosed;

            byte[] certFile = System.IO.File.ReadAllBytes(certFilePath);
            byte[] keyFile = System.IO.File.ReadAllBytes(keyFilePath);
            byte[] caFile = System.IO.File.ReadAllBytes(caFilePath);

            // Connect to MQTT broker with the configuration information
            mqttClient.Connect(Guid.NewGuid().ToString());

            // Subscribe to the MQTT topic for temperature
            mqttClient.Subscribe(new string[] { mqttTopic }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });

            isConnected = mqttClient.IsConnected;
            UpdateConnectionStatus();
        }

        private void MqttClient_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            // Receive MQTT message from the broker when there is a change
            string message = Encoding.UTF8.GetString(e.Message);
            Invoke((MethodInvoker)(() =>
            {
                temperatureLabel.Text = message;
            }));
        }

        private void MqttClient_ConnectionClosed(object sender, EventArgs e)
        {
            // Handle the event when MQTT connection is closed
            isConnected = false;
            UpdateConnectionStatus();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Update connection status when the form is loaded
            UpdateConnectionStatus();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            // Handle the event when Connect/Disconnect button is clicked
            if (!isConnected)
            {
                // Connect to MQTT broker
                InitializeMqttClient();
            }
            else
            {
                // Disconnect from MQTT broker
                mqttClient.Disconnect();
                isConnected = false;
                UpdateConnectionStatus();
            }
        }

        private void turnOnButton_Click(object sender, EventArgs e)
        {
            // Publish "1" message to the MQTT topic to turn on the light
            mqttClient.Publish(mqttTopic, Encoding.UTF8.GetBytes("1"), MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE, false);
        }

        private void turnOffButton_Click(object sender, EventArgs e)
        {
            // Publish "0" message to the MQTT topic to turn off the light
            mqttClient.Publish(mqttTopic, Encoding.UTF8.GetBytes("0"), MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE, false);
        }

        private void UpdateConnectionStatus()
        {
            // Update connection status and display on the UI
            connectButton.Text = isConnected ? "Disconnect" : "Connect";
            statusLabel.Text = isConnected ? "Connected" : "Disconnected";
        }
    }
}