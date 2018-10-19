namespace CycTest.Entities.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Invoice_report
    {
        public string Name { get; set; }
        public string Acc_No { get; set; }
        public int Invoice_Num { get; set; }
        public string Order_no { get; set; }
        public string salesmen { get; set; }
        public string cr_flag { get; set; }
        public Nullable<decimal> vat { get; set; }
        public Nullable<decimal> nbt { get; set; }
        public string L { get; set; }
        public string LT { get; set; }
        public string Cashier { get; set; }
        public decimal Cash { get; set; }
        public decimal Cheque { get; set; }
        public decimal Credit { get; set; }
        public decimal Discount { get; set; }
        public System.DateTime Date { get; set; }
        public Nullable<double> Cr_Qty { get; set; }
        public Nullable<double> Dr_Qty { get; set; }
        public string Stock_Card { get; set; }
        public string Descrip { get; set; }
        public Nullable<decimal> S_Price { get; set; }
        public Nullable<decimal> line_dis { get; set; }
        public Nullable<decimal> unit_Price { get; set; }
        public string SN { get; set; }
        public Nullable<decimal> Unit_Cost { get; set; }
        public decimal Credit_card { get; set; }
        public System.DateTime Cr_Date { get; set; }
        public int ID { get; set; }
        public int adinv { get; set; }
        public decimal advnce { get; set; }
        public short aprvd { get; set; }
        public string Job_no { get; set; }
        public Nullable<double> foc { get; set; }
        public string ofzr { get; set; }
        public System.DateTime tym { get; set; }
        public string Expr1 { get; set; }
        public Nullable<decimal> Act_prze { get; set; }
        public decimal inv_amnt { get; set; }
        public decimal ignr { get; set; }
        public decimal emp_set { get; set; }
        public Nullable<short> job_flag { get; set; }
        public string customer { get; set; }
        public decimal cash_res { get; set; }
        public string tid { get; set; }
        public Nullable<int> vat_v { get; set; }
        public Nullable<double> Nx { get; set; }
        public Nullable<double> Vx { get; set; }
        public string VAT_NO { get; set; }
        public Nullable<decimal> pre_bal { get; set; }
        public string VAT_Inv { get; set; }
        public Nullable<decimal> trcost { get; set; }
        public Nullable<int> adinv2 { get; set; }
        public Nullable<decimal> advnce2 { get; set; }
        public Nullable<decimal> R_price { get; set; }
        public string inv { get; set; }
        public string W_plan { get; set; }
        public Nullable<int> flag { get; set; }
        public string Caption { get; set; }
        public Nullable<int> exc { get; set; }
    }
}
