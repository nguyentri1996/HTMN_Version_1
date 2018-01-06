using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Manager_Hotel.Model
{
    class DeviceModel
    {
        private int deviceID;
        private string deviceName;
        private int deviceAmount;
        
        public int getDeviceID()
        {
            return deviceID;
        }
        public string getDeviceName()
        {
            return deviceName;
        }
        public int getDeviceAmount()
        {
            return deviceAmount;
        }

        public void setDeviceID(int _deviceID)
        {
            deviceID = _deviceID;
        }
        public void setDeviceName(string _deviceName)
        {
            deviceName = _deviceName;
        }

    }

}
