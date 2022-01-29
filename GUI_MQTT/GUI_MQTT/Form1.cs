using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace GUI_MQTT
{
    public partial class btt_Lichtaus : Form
    {
        MqttClient mqttClient;
        public btt_Lichtaus()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            mqttClient = new MqttClient("10.0.0.70");
            mqttClient.Connect("10.0.0.70");
            mqttClient.MqttMsgPublishReceived += MqttClient_MqttMsgPublishReceived;
            mqttClient.Subscribe(new string[] { "temp" }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_MOST_ONCE });
            mqttClient.Subscribe(new string[] { "light" }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_MOST_ONCE });
        }

        private void btt_start_Click(object sender, EventArgs e)
        {           
            mqttClient.Publish("light", Encoding.UTF8.GetBytes("an"));
        }



        private void MqttClient_MqttMsgPublishReceived(object sender, uPLibrary.Networking.M2Mqtt.Messages.MqttMsgPublishEventArgs e)
        {
         var message = Encoding.UTF8.GetString(e.Message);
           
            if(e.Topic == "temp")
            {
                txt_Temp.Invoke((MethodInvoker)(() => txt_Temp.Text = message));
            }

            if (e.Topic == "light")
            {
                if (message == "an")
                {
                    pgr_Licht.Invoke((MethodInvoker)(() => pgr_Licht.Value = 1));

                }
                if (message == "aus")
                {
                    pgr_Licht.Invoke((MethodInvoker)(() => pgr_Licht.Value = 0));
                }
            }

            
        }

        private void btt_Licht_aus_Click(object sender, EventArgs e)
        {
            mqttClient.Publish("light", Encoding.UTF8.GetBytes("aus"));
        }
    }
}
