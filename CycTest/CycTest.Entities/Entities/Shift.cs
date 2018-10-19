namespace CycTest.Entities.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Shift
    {
        public Nullable<int> Emp_Code { get; set; }
        public Nullable<System.DateTime> In_Date { get; set; }
        public Nullable<System.DateTime> in_time { get; set; }
        public string login { get; set; }
        public Nullable<System.DateTime> Out_date { get; set; }
        public Nullable<System.DateTime> Out_time { get; set; }
        public Nullable<int> ot_off { get; set; }
        public Nullable<int> aproved_ot { get; set; }
        public Nullable<int> Sun { get; set; }
        public Nullable<int> Sat { get; set; }
        public Nullable<int> mm { get; set; }
        public Nullable<int> yy { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<System.DateTime> IN_DateTime { get; set; }
        public Nullable<System.DateTime> OUT_DateTime { get; set; }
        public Nullable<int> Flag { get; set; }
        public int ID { get; set; }
    }
}
