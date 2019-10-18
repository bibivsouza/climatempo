using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClimaTempo.Model
{
   public class Cidade
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Clima { get; set; }
        public string Temperatura { get; set; }


        public override string ToString()
        {
            return Name;
        }
    }

}
