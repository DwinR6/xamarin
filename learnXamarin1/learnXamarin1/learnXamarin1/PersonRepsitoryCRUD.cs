using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using learnXamarin1.Models;

namespace learnXamarin1
{
  public class PersonRepsitoryCRUD
    {

        SQLiteConnection conn;
        public string StatusMessage { get; set; }

        public PersonRepsitoryCRUD(string dbPath)
        {
            conn = new SQLiteConnection(dbPath);
            conn.CreateTable<Person>();
        }
           
    }
}
