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
    
    public partial class Buy
    {
        public Nullable<System.Guid> OrId { get; set; }
        public string Code { get; set; }
        public Nullable<double> BuyPrice { get; set; }
        public string Name { get; set; }
        public Nullable<int> Number { get; set; }
        public Nullable<double> Price { get; set; }
        public Nullable<double> Pay { get; set; }
        public Nullable<double> Amounts { get; set; }
        public Nullable<int> TeBi { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<long> TranNo { get; set; }
        public System.Guid Gid { get; set; }
    
        public virtual Orders Orders { get; set; }
    }
}
