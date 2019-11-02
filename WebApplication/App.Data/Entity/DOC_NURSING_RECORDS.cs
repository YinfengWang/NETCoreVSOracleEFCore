using App.Core;
using System;
namespace App.Data.Entity
{
    /// <summary>
    /// 护理记录表
    /// </summary>
    public partial class DOC_NURSING_RECORDS : BaseEntity
    {
        public string ID { get; set; }
        public string NURSE_CODE { get; set; }
        public string PATIENT_ID { get; set; }
        public string VISIT_ID { get; set; }
        public string NURSING_CLASS { get; set; }
        public Nullable<System.DateTime> NURSE_TIME { get; set; }
        public string BODY_TEMPERATURE { get; set; }
        public string HEART_RATE { get; set; }
        public string BREATHE { get; set; }
        public string BLOOD_PRESSURE { get; set; }
        public string SP_ZERO_TWO { get; set; }
        public string REMARKS { get; set; }
        public string SIGNATURE { get; set; }
        public Nullable<short> PROCESSING_STATUS { get; set; }
        public string OPERATE_TYPE { get; set; }
        public string CREATE_USER { get; set; }
        public Nullable<System.DateTime> CREATE_TIME { get; set; }
        public string UPDATE_USER { get; set; }
        public Nullable<System.DateTime> UPDATE_TIME { get; set; }

    }
}
