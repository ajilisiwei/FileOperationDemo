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
    
    public partial class OptRecordBak
    {
        public System.Guid OpId { get; set; }
        public Nullable<int> MerId { get; set; }
        public string OpTableName { get; set; }
        public Nullable<int> OpType { get; set; }
        public Nullable<bool> IsSync { get; set; }
        public string OpTableId { get; set; }
        public Nullable<int> OpTableIdType { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
    }
}
