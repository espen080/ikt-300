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

            }
        }


        private void cbx_psu_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            Id = cbx_psu_id.SelectedIndex;
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            string hostname = tbx_host.Text;
            messageService = MessageServiceFactory.GetMessageService("MQTT", hostname);
            messageService.Connect(SubscriptionHandler);
            messageService.Subscribe("PSU/LIST");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}