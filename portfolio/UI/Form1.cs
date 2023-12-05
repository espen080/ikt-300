using MessageService;
using System.Text.Json;

namespace UI
{
    public partial class Form1 : Form
    {
        IMessageService messageService;
        string Id;
        string baseTopic;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void SubscriptionHandler(string topic, string message)
        {
            if(topic.ToLower() == "psu/list")
            {
                List<int>? iDs = JsonSerializer.Deserialize<List<int>>(message);
                if (iDs == null) return;
                this.Invoke(delegate () { 
                    int selected = cbx_psu_id.SelectedIndex;
                    cbx_psu_id.Items.Clear();
                    foreach (int id in iDs)
                    {
                        cbx_psu_id.Items.Add(id);
                    }
                    cbx_psu_id.SelectedIndex = selected;
                });
                return;
            }

            string[] topics = topic.Split("/");
            switch (topics[3].ToLower())
            {
                case "current":
                    this.Invoke(delegate () {tbx_get_current.Text = message; });
                    break;
                case "status":
                    this.Invoke(delegate () {
                        bool isLocked = message.ToLower() == "lock" ? true : false;
                        check_lock.Checked = isLocked;
                    });
                    break;
                case "voltage":
                    this.Invoke(delegate () { tbx_get_voltage.Text = message; });
                    break;
                case "stop":
                    this.Invoke(delegate () { 
                        tbx_get_voltage.Text = "";
                        tbx_get_current.Text = "";
                        tbx_set_voltage.Text = "";
                    });
                    break;
                default:
                    break;
            }
        }


        private void cbx_psu_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            Id = cbx_psu_id.SelectedItem.ToString();
            baseTopic = string.Format("PSU/{0}", Id);
            string topic = baseTopic + "/SERVER/#";
            messageService.Subscribe(topic);
            tbx_get_current.Text = "";
            tbx_get_voltage.Text = "";
            tbx_set_voltage.Text = "";
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            string hostname = tbx_host.Text;
            messageService = MessageServiceFactory.GetMessageService("MQTT", hostname);
            messageService.Connect(SubscriptionHandler);
            messageService.Subscribe("PSU/LIST");
            if (int.TryParse(tbx_frequency.Text, out int frequency))
            {
                messageService.Publish("PSU/FREQUENCY", frequency.ToString());
            }
            btn_frequency.Enabled = true;
        }

        private void btn_set_voltage_Click(object sender, EventArgs e)
        {
            if (cbx_psu_id.SelectedIndex == -1)
                return;
            if (float.TryParse(tbx_set_voltage.Text, out float voltage))
            {
                messageService.Publish(baseTopic + "/VOLTAGE/SET", voltage.ToString());
            }
        }

        private void btn_get_voltage_Click(object sender, EventArgs e)
        {
            if (cbx_psu_id.SelectedIndex == -1)
                return;
            messageService.Publish(baseTopic + "/VOLTAGE/GET");
        }

        private void btn_get_current_Click(object sender, EventArgs e)
        {
            if (cbx_psu_id.SelectedIndex == -1)
                return;
            messageService.Publish(baseTopic + "/CURRENT/GET");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool value = check_lock.Checked;
            check_lock.Checked = value;
            if (cbx_psu_id.SelectedIndex == -1)
                return;
            string message = check_lock.Checked ? "LOCK" : "UNLOCK";
            messageService.Publish(baseTopic + "/STATUS", message);
        }

        private void btn_frequency_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbx_frequency.Text, out int frequency))
            {
                messageService.Publish("PSU/FREQUENCY", frequency.ToString());
            }
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            if (cbx_psu_id.SelectedIndex == -1)
                return;
            messageService.Publish(baseTopic + "/STOP");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (messageService != null)
            {
                messageService.Disconnect();
            }
        }
    }
}