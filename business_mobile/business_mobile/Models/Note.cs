using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace business_mobile.Models
{
    public class Note
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string TaskID { get; set; }
        public string TaskName { get; set; }
        public DateTime TaskDate { get; set; }
        public string TaskDescription { get; set; }
        public string UserID { get; set; }
        public bool Processed { get; set; }
    }
}
