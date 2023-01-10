using bank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace bank
{




        public class client
        {
            public client(string id, string name, string accountnr, decimal accountvalue) 
            {
                this.Id= id;
                this.Name= name;
                this.AccountNr= accountnr;
                this.AccountValue= accountvalue;
            }
        public string Id { get; set; }
        public string Name { get; set; }
        public string AccountNr { get; set; }
        public decimal AccountValue { get; set; }
        


        }
 

}
