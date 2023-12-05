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

            return null;
        }

        static IPSU GetTestPSU()
        {
            return new TestPSU();
        }

        public static Dictionary<string, IPSU> GetPSUs()
        {
            Dictionary<string, IPSU> list = new();
            List<string> comPorts = SerialPort.GetPortNames().Distinct().ToList();
            foreach (string comPort in comPorts)
            {
                IPSU psu = GetPSU(comPort);
                if (psu != null)
                    list.Add(psu.GetName(), psu);
            }
            if ( list.Count == 0)
            {
                Console.WriteLine("Warning: No PSUs detected, adding test stub PSU");
                IPSU psu = GetTestPSU();
                list.Add(psu.GetName(), psu);
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
        public string GetName();

    }
}
