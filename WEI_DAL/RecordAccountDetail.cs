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
    
    public partial class RecordAccountDetail
    {
        public System.Guid RadId { get; set; }
        public long TranNo { get; set; }
        public System.Guid Gid { get; set; }
        public decimal Amount { get; set; }
        public decimal OweCash { get; set; }
        public System.Guid ReaId { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string CreatedBy { get; set; }
    }
}
