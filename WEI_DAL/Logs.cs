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
    
    public partial class Logs
    {
        public System.Guid Id { get; set; }
        public int Merid { get; set; }
        public string ExceptionLevel { get; set; }
        public string ExceptionClass { get; set; }
        public string ClassName { get; set; }
        public string MethodName { get; set; }
        public string MethodFunc { get; set; }
        public string MethodParams { get; set; }
        public string MethodReturn { get; set; }
        public string Ex { get; set; }
        public string Remark { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string CreatedBy { get; set; }
    }
}
