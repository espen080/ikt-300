using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSU
{
    internal class TestPSU: IPSU
    {
        float voltage = 0;

        public string GetVoltage()
        {
            return voltage.ToString();
        }
        public bool SetVoltage(float setVolt)
        {
            voltage = setVolt;
            return true;
        }
        public string GetCurrent()
        {
            return "0";
        }
        public bool RemoteControlEnabled(bool setEnabled)
        {
            return true;
        }

        public bool IsValid()
        {
            return true;
        }

        public string GetName()
        {
            return "TestPSU_1";
        }
    }
}
