using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;




namespace CycTest.Entities.Entities
{

    public partial class Stock_Book
    {
        [Key] [Required] 
        public int ID { get; set; }
        public string Name { get; set; }
        public Nullable<int> Old_ID { get; set; }
        public string FLAGT { get; set; }
    }
}
