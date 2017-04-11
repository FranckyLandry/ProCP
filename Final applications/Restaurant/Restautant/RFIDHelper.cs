using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phidgets;
using Phidgets.Events;

namespace Restaurant
{
    
   
    class RFIDHelper
    {
        public delegate void SendMessage(RFIDHelper R, string message);
        public event SendMessage SendEventMessage;
       // private bool checkINorOut = false;

        public void ShowWhoIsAttached(object sender, AttachEventArgs e)
        {
           
            string s = "RFID Reader attached!," + e.Device.SerialNumber;
            SendEventMessage(this, "The RFID is attached"+e.Device.SerialNumber);

        }

        public void ShowWhoIsDetached(object sender, DetachEventArgs e)
        {
          string s = "RFIDReader detached!, serial nr: " + e.Device.SerialNumber.ToString();
           
        }

        public  void ProcessThisTag(object sender, TagEventArgs e)
        {
            string s = "" + e.Tag;
        }



    }
}
