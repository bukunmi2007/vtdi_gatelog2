//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace vtdi_gatelog2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Gate_In_Out
    {
        public int Id { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public int Vehicle_type_id { get; set; }
        public string Plate_number { get; set; }
        public int Purpose_of_visit_id { get; set; }
        public int Item_to_declare_id { get; set; }
        public int User_id { get; set; }
        public System.DateTime Date_Time_in { get; set; }
        public System.DateTime Date_Time_out { get; set; }
    
        public virtual Item_To_Declare Item_To_Declare { get; set; }
        public virtual Purpose_of_Visit Purpose_of_Visit { get; set; }
        public virtual User User { get; set; }
        public virtual Vehicle_Type Vehicle_Type { get; set; }
    }
}
