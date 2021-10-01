using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChildCaseMgt.Model
{
    class StriveAndThriveData
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string Iron_Prop { get; set; }
        public string VitaminA { get; set; }
        public string Aneamia_Prop { get; set; }
        public string Zinc { get; set; }
        public string Polio { get; set; }
        public string Hepatitis { get; set; }
    }
}
