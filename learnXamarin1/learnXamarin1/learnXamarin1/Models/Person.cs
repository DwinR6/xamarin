using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace learnXamarin1.Models
{
    [Table("People")]
    public class Person
    {

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(50), Unique]
        public string Name { get; set; }

    }
}
