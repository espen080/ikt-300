using MessageService;
using System.Text.Json;

namespace UI
{
    public partial class Form1 : Form
    {
        private IMessageService messageService;
        private int Id;
        public Form1()
        {
            InitializeComponent();
            messageService = MessageServiceFactory.GetMessageService("MQTT", "127.0.0.1");
            messageService.Connect(SubscriptionHandler);
            messageService.Subscribe("PSU/LIST");
            messageService.Publish("PSU/CONNECT");
           
        }

        private void SubscriptionHandler(string topic, string message)
        {
            if(topic.ToLower() == "psu/list" && cbx_psu_id.Items.Count == 0)
            {
                List<int>? iDs = JsonSerializer.Deserialize<List<int>>(message);
                if (iDs == null) return;
                foreach (int id in iDs)
                {
                    this.Invoke(delegate () { cbx_psu_id.Items.Add(id); });
                }
            }
        }

        private void btn_set_volt_Click(object sender, EventArgs e)
        {
            float setVolt = float.Parse(tbx_set_volt.Text);

        }

        private void btn_get_volt_Click(object sender, EventArgs e)
        {
            tbx_get_volt.Text = "";
        }

        private void remote_control_CheckedChanged(object sender, EventArgs e)
        {
            
        }


        private void rdi_power_enabled_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbx_psu_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            Id = cbx_psu_id.SelectedIndex;
        }
    }
}