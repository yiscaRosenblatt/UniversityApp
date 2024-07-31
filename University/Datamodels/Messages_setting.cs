using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Datamodels
{
    public class Messages_setting
    {
        public string SendedName { get; set; }
        public string text { get; set; }
        public bool isFivorit {  get; set; }
        public DateTime Date { get; set; }

        public Messages_setting(string sendedName, string text, DateTime date)
        {
            this.SendedName = sendedName;
            this.text = text;
            this.isFivorit = false;
            this.Date = date;
        }
    }
}
