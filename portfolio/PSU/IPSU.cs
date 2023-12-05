using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSU
{
    public static class PSUFactory
    { 
        public static IPSU GetPSU(string type, string comPort) 
        { 
            switch (type.ToLower())
            {
                case "test":
                    return new TestPSU();
                case "ps2000b":
                    return new PS2000b(comPort);
                default:
                    return null;
            }
        }
    }

    public interface IPSU
    {
        public string GetVoltage();
        public bool SetVoltage(float setVolt);
        public string GetCurrent();
        public bool RemoteControlEnabled(bool setEnabled);
    }
}
