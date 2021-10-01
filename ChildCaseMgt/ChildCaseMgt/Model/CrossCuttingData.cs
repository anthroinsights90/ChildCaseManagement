using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChildCaseMgt.Model
{
    class CrossCuttingData
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
    }
}
