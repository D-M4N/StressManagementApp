using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLitePCL;

namespace SimpleApp.Registration
{
    public class InformationTable
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public string ContactDetails { get; set; }
               

        bool Done { get; set; }
    }
}
