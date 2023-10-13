using PSUManager;

namespace UI
{
    public partial class Form1 : Form
    {
        private IManager PSU;
        public Form1()
        {
            InitializeComponent();
            PSU = PSUManagerFactory.GetManager(tbx_port.Text);
            if (PSU.TestComPort())
                LoadPSU();
            

        }

        private void LoadPSU()
        {
            // Load device information
            tbx_device_type.Text = PSU.GetDeviceType();
            tbx_serialno.Text = PSU.GetSerialNumber();
            tbx_nom_volt.Text = PSU.GetNominalVoltage();
            tbx_nom_watt.Text = PSU.GetNominalWatt();
            tbx_articleno.Text = PSU.GetArticeNo();
            tbx_manufacturer.Text = PSU.GetManufacturer();
            tbx_version.Text = PSU.GetSoftwareVersion();

            // Enable remote control on startup
            PSU.EnableRemoteControl();
            cbx_remote_control.Checked = true;

            // Disable power out on startup
            PSU.DisablePowerOut();
            cbx_power_out.Checked = false;
        }

        private void btn_set_volt_Click(object sender, EventArgs e)
        {
            float setVolt = float.Parse(tbx_set_volt.Text);
            PSU.SetVoltage(setVolt);
            tbx_get_volt.Text = PSU.GetVoltage();

        }


        private void btn_get_volt_Click(object sender, EventArgs e)
        {
            tbx_get_volt.Text = PSU.GetVoltage();
        }



        private void remote_control_CheckedChanged(object sender, EventArgs e)
        {
            bool success = cbx_remote_control.Checked ? PSU.EnableRemoteControl() : PSU.EnableManualControl();
            if (!success)
            {
                cbx_remote_control.Checked = !cbx_remote_control.Checked;
            }
        }

        private void btn_get_watt_Click(object sender, EventArgs e)
        {
            tbx_get_watt.Text = "loading watt";
        }

        private void btn_set_watt_Click(object sender, EventArgs e)
        {

        }

        private void rdi_power_enabled_CheckedChanged(object sender, EventArgs e)
        {
            bool success = cbx_power_out.Checked ? PSU.EnablePowerOut() : PSU.DisablePowerOut();
            if (!success)
            {
                cbx_power_out.Checked = !cbx_power_out.Checked;
            }
        }

        private void tbx_port_TextChanged(object sender, EventArgs e)
        {
            PSU.ComPort = tbx_port.Text;
        }
    }
}