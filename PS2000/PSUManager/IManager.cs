using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSUManager
{
    public static class PSUManagerFactory
    {
        public static IManager GetManager(string com_port) { return new Manager(com_port); }
    }

    public interface IManager
    {
        public bool TestComPort();
        public string ComPort { get; set; }
        public string GetDeviceType();
        public string GetSerialNumber();
        public string GetNominalVoltage();
        public string GetVoltage();
        public string GetNominalWatt();
        public string GetArticeNo();
        public string GetManufacturer();
        public string GetSoftwareVersion();
        public bool EnableRemoteControl();
        public bool EnableManualControl();
        public bool EnablePowerOut();
        public bool DisablePowerOut();
        public bool SetVoltage(float setVolt);
    }
}
