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
    
    public partial class Notifies
    {
        public int TypeId { get; set; }
        public Nullable<int> MerId { get; set; }
        public Nullable<int> TimeLength { get; set; }
        public Nullable<System.DateTime> NotifyTime { get; set; }
        public int NotifyStatus { get; set; }
        public string PhoneNo { get; set; }
        public string CardNo { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
        public System.Guid Gid { get; set; }
        public string NotiContent { get; set; }
        public System.Guid BtId { get; set; }
    }
}
