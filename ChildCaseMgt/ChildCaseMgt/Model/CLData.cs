using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChildCaseMgt.Model
{
    class CLData
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Education { get; set; }
        public string Province { get; set; }
        public string Enrolled { get; set; }

    }
}
