using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI2
{
    class ClientInfo
    {
        /// <summary>
        /// Fields wich will read the file
        /// </summary>
       

        /// <summary>
        /// Properties
        /// </summary>
        public string EventAccount { get; private set; }
        public string Amount { get; private set; }
        public string RfidFields { get; private set; }
        public string DateUpload { get; private set; }
        public string DateEnd { get; private set; }
        public string Year { get;  set; }
        public string Month { get;  set; }
        public string Days { get;  set; }

        public ClientInfo(string rfidFields, string dateUpload, string amount, string eventA, string dateEnd)
        {
            this.EventAccount = eventA;
            this.DateUpload = dateUpload;
            this.RfidFields = rfidFields;
            this.Amount = amount;
            this.DateEnd = dateEnd;
        }


        public override string ToString()
        {
            


           // string query = "this is an example: INSERT INTO tableinfo (name, age) VALUES('John Smith', '33')";
            string query = "INSERT INTO logfilepaypal(RFID_Nr,DateAndTime_file_upload,Amount,Event_Account,DateAndTim_file_end) VALUE('" ;
            query += this.RfidFields + "','" + this.DateUpload + "','" + this.Amount + "','" + this.EventAccount + "','" + this.DateEnd;
            return query;
        }

    }
}
