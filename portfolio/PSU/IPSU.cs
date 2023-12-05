using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSU
{
    public static class PSUFactory
    { 
        public static IPSU GetPSU(string comPort) 
        { 
            IPSU PSU = new PS2000b(comPort);
            if( PSU.IsValid())
                return PSU;

            // Add more definitions as neccessary

            // Use only for testing
            PSU = new TestPSU();
            if (PSU.IsValid())
                return PSU;
            return null;
        }

        public static List<IPSU> GetPSUList()
        {
            List<IPSU> list = new();
            string[] comPorts = SerialPort.GetPortNames();
            foreach (string comPort in comPorts)
            {
                IPSU psu = GetPSU(comPort);
                if (psu != null)
                    list.Add(psu);
            }
            return list;
        }
    }

    public interface IPSU
    {
        public string GetVoltage();
        public bool SetVoltage(float setVolt);
        public string GetCurrent();
        public bool RemoteControlEnabled(bool setEnabled);
        public bool IsValid();

    }
}
