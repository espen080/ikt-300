using System.IO.Ports;

namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Load device information
            LoadDeviceType();
            LoadSerialNumber();
            LoadNominalVoltage();
            LoadNominalWatt();
            LoadArticeNo();
            LoadManufacturer();
            LoadSoftwareVersion();

            // Enable remote control on startup
            EnableRemoteControl();
            rdi_remote_enabled.Checked = true;

        }

        void LoadDeviceType()
        {
            var telegram = Telegram(
                sd: StartDelimiter(MessageType.Query, Direction.ToDevice, 15),
                obj: Object.DeviceType
            );
            var responseTelegram = sendTelegram(telegram);

            tbx_device_type.Text = EncodeResponse(responseTelegram);
        }

        void LoadSerialNumber()
        {
            var telegram = Telegram(
                sd: StartDelimiter(MessageType.Query, Direction.ToDevice, 15),
                obj: Object.SerialNo
            );
            var responseTelegram = sendTelegram(telegram);

            tbx_serialno.Text = EncodeResponse(responseTelegram);
        }

        string GetVoltage()
        {
            double volt;
            int percentVolt = 0;

            // get voltage
            var statusTelegram = Telegram(
                sd: StartDelimiter(MessageType.Query, Direction.ToDevice, 5),
                obj: Object.Status
            );
            var statusResponseTelegram = sendTelegram(statusTelegram);
            if (statusResponseTelegram == null)
            {
                Console.WriteLine("No telegram was read");
            }
            else
            {
                string percentVoltString = statusResponseTelegram[5].ToString("X") + statusResponseTelegram[6].ToString("X");
                percentVolt = Convert.ToInt32(percentVoltString, 16);
            }

            // get nominal voltage
            var voltageTelegram = Telegram(
                sd: StartDelimiter(MessageType.Query, Direction.ToDevice, 3),
                obj: Object.NominalVoltage
            );
            var voltageResponseTelegram = sendTelegram(voltageTelegram);

            float nominalVoltage = 0;
            if (voltageResponseTelegram == null)
            {
                return "";
            }
            else
            {
                byte[] byteArray = { voltageResponseTelegram[6], voltageResponseTelegram[5], voltageResponseTelegram[4], voltageResponseTelegram[3] };
                nominalVoltage = BitConverter.ToSingle(byteArray, 0);
                volt = (double)percentVolt * nominalVoltage / 25600;
                return volt.ToString();
            }
        }

        void LoadNominalVoltage()
        {
            // get nominal voltage
            var voltageTelegram = Telegram(
                sd: StartDelimiter(MessageType.Query, Direction.ToDevice, 3),
                obj: Object.NominalVoltage
            );
            var voltageResponseTelegram = sendTelegram(voltageTelegram);

            float nominalVoltage = 0;
            if (voltageResponseTelegram == null)
            {
                Console.WriteLine("No telegram was read");
                tbx_nom_volt.Text = "";
            }
            else
            {
                byte[] byteArray = { voltageResponseTelegram[6], voltageResponseTelegram[5], voltageResponseTelegram[4], voltageResponseTelegram[3] };
                nominalVoltage = BitConverter.ToSingle(byteArray, 0);
                tbx_nom_volt.Text = nominalVoltage.ToString();
            }
        }

        void LoadNominalWatt()
        {
            var telegram = Telegram(
                sd: StartDelimiter(MessageType.Query, Direction.ToDevice, 3),
                obj: Object.NominalWatt
            );
            var responseTelegram = sendTelegram(telegram);

            tbx_nom_watt.Text = "Not implemented";
        }

        void LoadArticeNo()
        {
            var telegram = Telegram(
                sd: StartDelimiter(MessageType.Query, Direction.ToDevice, 15),
                obj: Object.DeviceArticleNo
            );
            var responseTelegram = sendTelegram(telegram);

            tbx_articleno.Text = EncodeResponse(responseTelegram);
        }

        void LoadManufacturer()
        {
            var telegram = Telegram(
                sd: StartDelimiter(MessageType.Query, Direction.ToDevice, 15),
                obj: Object.Manufacturer
            );
            var responseTelegram = sendTelegram(telegram);

            tbx_manufacturer.Text = EncodeResponse(responseTelegram);
        }

        void LoadSoftwareVersion()
        {
            var telegram = Telegram(
                sd: StartDelimiter(MessageType.Query, Direction.ToDevice, 15),
                obj: Object.SoftwareVersion
            );
            var responseTelegram = sendTelegram(telegram);

            tbx_version.Text = EncodeResponse(responseTelegram);
        }

        static bool EnableRemoteControl()
        {
            var telegram = Telegram(
                sd: StartDelimiter(MessageType.Send, Direction.ToDevice, 1),
                obj: Object.PowerSupplyControl,
                data: new byte[] { 0x10, 0x10 }
            );

            var responseTelegram = sendTelegram(telegram);
            return responseTelegram[3] == 0;
        }

        static bool EnableManualControl()
        {
            var telegram = Telegram(
                sd: StartDelimiter(MessageType.Send, Direction.ToDevice, 1),
                obj: Object.PowerSupplyControl,
                data: new byte[] { 0x10, 0x00 }
            );
            var responseTelegram = sendTelegram(telegram);
            return responseTelegram[3] == 0;
        }

        static bool EnablePowerOut()
        {
            var telegram = Telegram(
                sd: StartDelimiter(MessageType.Send, Direction.ToDevice, 1),
                obj: Object.PowerSupplyControl,
                data: new byte[] { 0x01, 0x01 }
            );
            var responseTelegram = sendTelegram(telegram);
            return responseTelegram[3] == 0;
        }

        static bool DisablePowerOut()
        {
            var telegram = Telegram(
                sd: StartDelimiter(MessageType.Send, Direction.ToDevice, 1),
                obj: Object.PowerSupplyControl,
                data: new byte[] { 0x01, 0x00 }
            );
            var responseTelegram = sendTelegram(telegram);
            return responseTelegram[3] == 0;
        }

        private void set_voltage()
        {
            // setting voltage
            // remember to turn on remote control first
            if (!rdi_remote_enabled.Checked) 
            { 
                rdi_remote_enabled.Checked = EnableRemoteControl();
            }

            // 
            float setVolt = float.Parse(tbx_set_volt.Text);
            int percentSetValue = (int)Math.Round((25600 * setVolt) / 84);
            var (byte1, byte2) = CalculateSetValue(percentSetValue);

            var telegram = Telegram(
                sd: StartDelimiter(MessageType.Send, Direction.ToDevice, 5),
                obj: Object.SetVoltage,
                data: new byte[] { byte1, byte2 }
            );
            var responseTelegram = sendTelegram(telegram);
            if (responseTelegram[3] == 0)
            {
                Console.WriteLine("New voltage was set");
            }
            else
            {
                Console.WriteLine(responseTelegram[3].ToString());
            }
        }

        private void btn_set_volt_Click(object sender, EventArgs e)
        {
            set_voltage();
        }

        private enum MessageType
        {
            Send = 0xC0,
            Query = 0x40,
            Answer = 0x80
        }

        private enum Object
        {
            DeviceType = 0x00,
            SerialNo = 0x01,
            NominalVoltage = 0x02,
            NominalWatt = 0x04,
            DeviceArticleNo = 0x06,
            Manufacturer = 0x08,
            SoftwareVersion = 0x09,
            Status = 0x47,
            PowerSupplyControl = 0x36,
            SetVoltage = 0x32
        }

        private enum Direction
        {
            ToDevice = 0x10,
            FromDevice = 0x00
        }

        static List<byte> sendTelegram(byte[] telegram)
        {
            List<byte> responseTelegram;
            using (SerialPort port = new SerialPort("Com6", 115200, 0, 8, StopBits.One))
            {
                Thread.Sleep(500);
                port.Open();
                // write to the USB port
                port.Write(telegram, 0, telegram.Length);
                Thread.Sleep(500);

                responseTelegram = new List<byte>();
                int length = port.BytesToRead;
                if (length > 0)
                {
                    byte[] message = new byte[length];
                    port.Read(message, 0, length);
                    foreach (var t in message)
                    {
                        responseTelegram.Add(t);
                    }
                }
                port.Close();
                Thread.Sleep(500);
            }
            return responseTelegram;
        }

        private static byte[] Telegram(byte sd, Object obj, byte[]? data = null)
        {
            data = data ?? new byte[0];
            byte[] telegram = new byte[5 + data.Length];
            
            //Set telegram bytes
            telegram[0] = sd; //SD
            telegram[1] = 0x00; // DN = 0, Single models only have one output (Output 1 == 0x00)
            telegram[2] = (byte)obj; //OBJ
            //Insert data bytes
            for (int i = 0; i < data.Length; i++)
            {
                telegram[i+3] = (byte)data[i];
            }
            
            // Add checksum
            telegram[3 + data.Length] = 0x00; // Checksum 1
            telegram[4+ data.Length] = 0x00; // Checksum 2
            CalculateChechsum(ref telegram);

            return telegram;
        }

        private static byte StartDelimiter(MessageType messageType, Direction direction, int length)
        {
            //SD = MessageType + CastType + Direction + Length
            int SDHex = (int)messageType + (int)0x20 + (int)direction + length; //6-1 ref spec 3.1.1
            return Convert.ToByte(SDHex.ToString(), 10);
        }

        private static void CalculateChechsum(ref byte[] telegram)
        {
            int sum = 0;
            int arrayLength = telegram.Length;
            for (int i = 0; i < arrayLength; i++)
            {
                sum += telegram[i];
            }

            string hexSum = sum.ToString("X");
            string cs1 = "";
            string cs2 = "";
            if (hexSum.Length == 4)
            {
                cs1 = hexSum.Substring(0, hexSum.Length / 2);
                cs2 = hexSum.Substring(hexSum.Length / 2);
            }
            else if (hexSum.Length == 3)
            {
                cs1 = hexSum.Substring(0, 1);
                cs2 = hexSum.Substring(1);
            }
            else if ((hexSum.Length is 2) || (hexSum.Length is 1))
            {
                cs1 = "0";
                cs2 = hexSum;
            }

            if (cs1 != "")
            {
                telegram[arrayLength - 2] = Convert.ToByte(cs1, 16);
                telegram[arrayLength - 1] = Convert.ToByte(cs2, 16);
            }
        }

        private static (byte, byte) CalculateSetValue(int setValue)
        {
            string hexValue = setValue.ToString("X");
            string hexValue1 = "";
            string hexValue2 = "";

            if (hexValue.Length == 4)
            {
                hexValue1 = hexValue.Substring(0, hexValue.Length / 2);
                hexValue2 = hexValue.Substring(hexValue.Length / 2);
            }
            else if (hexValue.Length == 3)
            {
                hexValue1 = hexValue.Substring(0, 1);
                hexValue2 = hexValue.Substring(1);
            }
            else if ((hexValue.Length is 2) || (hexValue.Length is 1))
            {
                hexValue1 = "0";
                hexValue2 = hexValue;
            }

            return (Convert.ToByte(hexValue1, 16), Convert.ToByte(hexValue2, 16));
        }

        private void btn_get_volt_Click(object sender, EventArgs e)
        {
            tbx_get_volt.Text = GetVoltage();
        }

        private string EncodeResponse(List<byte> telegram)
        {
            string binary = Convert.ToString(telegram[0], 2);
            string payloadLengtBinaryString = binary.Substring(4);
            int payloadLength = Convert.ToInt32(payloadLengtBinaryString, 2);
            string responseString = "";

            for (var i = 0; i < payloadLength; i++)
            {
                responseString += Convert.ToChar(telegram[3 + i]);
            }
            return responseString;
        }

        private void remote_control_CheckedChanged(object sender, EventArgs e)
        {
            bool success = rdi_remote_enabled.Checked ? EnableRemoteControl() : EnableManualControl();
            if (!success)
            {
                rdi_remote_enabled.Checked = !rdi_remote_enabled.Checked;
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
            bool success = rdi_power_enabled.Checked ? EnablePowerOut() : DisablePowerOut();
            if (!success)
            {
                rdi_power_enabled.Checked = !rdi_power_enabled.Checked;
            }
        }
    }
}