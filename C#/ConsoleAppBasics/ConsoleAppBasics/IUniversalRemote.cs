using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBasics
{
    interface IUniversalRemote
    {
        void SwitchOn();
        void SwitchOff();
        int ChangeVolume(int vol);
        string ChangeChannel(string chanel);
    }
}
