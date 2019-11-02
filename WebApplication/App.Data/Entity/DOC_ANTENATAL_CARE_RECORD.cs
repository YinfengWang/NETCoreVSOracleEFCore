using App.Core;
using System;
namespace App.Data.Entity
{
    /// <summary>
    /// 产前护理记录表
    /// </summary>
    public partial class DOC_ANTENATAL_CARE_RECORD : BaseEntity
    {

        public new string ID { get; set; }
        public string NURSE_CODE { get; set; }
        public string PATIENT_ID { get; set; }
        public string VISIT_ID { get; set; }
        public string NURSING_CLASS { get; set; }
        public Nullable<System.DateTime> NURSE_DATE { get; set; }
        public string BLOOD_PRESSURE { get; set; }
        public string CONTRACTION { get; set; }
        public string FETAL_HEART { get; set; }
        public string AMNIOTIC_FLUID { get; set; }
        public string YIN_ANAL_EXAMINATION { get; set; }
        public string VAGINAL_BLEEDING { get; set; }
        public string REMARKS { get; set; }
        public string SIGNATURE { get; set; }
        public Nullable<short> PROCESSING_STATUS { get; set; }
        public string OPERATE_TYPE { get; set; }
        public string CREATE_USER { get; set; }
        public Nullable<System.DateTime> CREATE_TIME { get; set; }
        public string UPDATE_USER { get; set; }
        public Nullable<System.DateTime> UPDATE_TIME { get; set; }
        public Nullable<int> BLOOD_PRESSURE_ID { get; set; }
        public Nullable<int> CONTRACTION_ID { get; set; }
        public Nullable<int> FETAL_HEART_ID { get; set; }
        public Nullable<int> AMNIOTIC_FLUID_ID { get; set; }
        public Nullable<int> YIN_ANAL_EXAMINATION_ID { get; set; }
        public Nullable<int> VAGINAL_BLEEDING_ID { get; set; }
        public Nullable<int> REMARKS_ID { get; set; }
    }
}
