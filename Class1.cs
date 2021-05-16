using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerCrypto
{
    class JsonData
    {
        private string hash;
        private string messageBase64;
        private string sender;
        private string reciever;

        public JsonData(string hash, string messageBase64, string sender, string reciever)
        {
            this.hash = hash;
            this.messageBase64 = messageBase64;
            this.sender = sender;
            this.reciever = reciever;
        }
    }
}
