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
    
    public partial class SystemSettings
    {
        public Nullable<int> MerId { get; set; }
        public Nullable<int> LeastCostTime { get; set; }
        public Nullable<int> LeastQuitTime { get; set; }
        public Nullable<int> AccountingUnit { get; set; }
        public Nullable<int> BilliardFreshTime { get; set; }
        public bool IsAllowQuit { get; set; }
        public Nullable<int> BalanceType { get; set; }
        public bool IsDrinkCostPrint { get; set; }
        public bool IsPersonalDrinkPrint { get; set; }
        public bool IsExchangeBilliardPrint { get; set; }
        public bool IsHourCostPrint { get; set; }
        public bool IsBeginPrint { get; set; }
        public bool IsRepeatPrint { get; set; }
        public string CompanyName { get; set; }
        public string PageHeader { get; set; }
        public string PageFooter { get; set; }
        public bool IsTurnPrint { get; set; }
        public bool CountObject { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
        public bool IsMenuRight { get; set; }
        public Nullable<int> Appointment { get; set; }
        public Nullable<int> FixedTime { get; set; }
        public System.Guid Gid { get; set; }
        public int ChargeRule { get; set; }
        public bool OpenWatchBallTable { get; set; }
        public bool OpenSparring { get; set; }
        public bool OpenTiming { get; set; }
        public bool OpenAppointment { get; set; }
        public bool OpenRecharge { get; set; }
        public bool OpenRecordAccount { get; set; }
        public bool OpenBento { get; set; }
        public bool OpenWaveClock { get; set; }
        public bool OpenMargin { get; set; }
        public bool PrintTwo { get; set; }
        public bool CloseLight { get; set; }
    }
}