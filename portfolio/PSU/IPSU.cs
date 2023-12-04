using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSU
{
    public static class PSUFactory
    { 
        public static IPSU GetPSU(string comPort) { return new PS2000b(comPort); }
    }

    public interface IPSU
    {
        public string GetVoltage();
        public bool SetVoltage(float setVolt);
        public string GetCurrent();
        public bool RemoteControlEnabled(bool setEnabled);
    }
}
