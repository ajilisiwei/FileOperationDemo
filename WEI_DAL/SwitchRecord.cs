//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WEI_DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class SwitchRecord
    {
        public Nullable<System.Guid> OrId { get; set; }
        public string FromNo { get; set; }
        public string ToNo { get; set; }
        public Nullable<double> Amounts { get; set; }
        public Nullable<int> TeBall { get; set; }
        public Nullable<int> TeBi { get; set; }
        public Nullable<System.DateTime> StartTime { get; set; }
        public Nullable<System.DateTime> EndTime { get; set; }
        public Nullable<int> TotalTime { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
        public System.Guid Gid { get; set; }
        public System.Guid BtId { get; set; }
        public System.Guid FromBtId { get; set; }
        public Nullable<System.DateTime> ActualBillingTime { get; set; }
    
        public virtual Orders Orders { get; set; }
    }
}
