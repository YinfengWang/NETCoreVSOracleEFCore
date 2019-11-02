using App.Core;
using System;
namespace App.Data.Entity
{
    /// <summary>
    /// 24小时出入量记录表
    /// </summary>
    public partial class DOC_DAYOUR_ENTRYEXIT_RECORD : BaseEntity
    {
        public  string ID { get; set; }
        public string NURSE_CODE { get; set; }
        public string PATIENT_ID { get; set; }
        public string VISIT_ID { get; set; }
        public string NURSING_CLASS { get; set; }
        public Nullable<System.DateTime> ENTRYEXIT_DATE { get; set; }
        public string DRINK_WATER { get; set; }
        public string WATERY_FOOD { get; set; }
        public string LIQUID_AMOUNT { get; set; }
        public string URINE { get; set; }
        public string DRAINAGE_VOMIT { get; set; }
        public string STOOL { get; set; }
        public string INVOLVEMENT { get; set; }
        public string AMOUNT { get; set; }
        public string SIGNATURE { get; set; }
        public Nullable<short> PROCESSING_STATUS { get; set; }
        public string OPERATE_TYPE { get; set; }
        public string CREATE_USER { get; set; }
        public Nullable<System.DateTime> CREATE_TIME { get; set; }
        public string UPDATE_USER { get; set; }
        public Nullable<System.DateTime> UPDATE_TIME { get; set; }
        public Nullable<int> DRINK_WATER_NO { get; set; }
        public Nullable<int> WATERY_FOOD_NO { get; set; }
        public Nullable<int> LIQUID_AMOUNT_NO { get; set; }
        public Nullable<int> URINE_NO { get; set; }
        public Nullable<int> DRAINAGE_VOMIT_NO { get; set; }
        public Nullable<int> STOOL_NO { get; set; }
        public Nullable<int> INVOLVEMENT_NO { get; set; }
        public Nullable<int> AMOUNT_NO { get; set; }
        public Nullable<int> SIGNATURE_NO { get; set; }
    }
}
