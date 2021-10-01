using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChildCaseMgt.Model
{
    class SafeAndCleanData
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set;}
        public string Age { get; set; }
        public string Province { get; set; }
        public string Area { get; set; }
        public string Water_Avaiability { get; set; }
        public string Water_Accessibility { get; set; }
        public string Water_Quality { get; set; }
        public string Water_Facility { get; set; }
        public string Wash_Facility { get; set; }
    }
}
