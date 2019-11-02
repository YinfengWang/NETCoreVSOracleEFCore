using App.Core;
using System;
namespace App.Data.Entity
{
    /// <summary>
    /// 产后护理记录表
    /// </summary>
    public partial class DOC_POSTPARTUM_NURSING_RECORD : BaseEntity
    {
        public  string ID { get; set; }
        public string NURSE_CODE { get; set; }
        public string PATIENT_ID { get; set; }
        public string VISIT_ID { get; set; }
        public string NURSING_CLASS { get; set; }
        public Nullable<System.DateTime> NURSE_DATE { get; set; }
        public string DELIVERY_MODE { get; set; }
        public string CONSCIOUS_SYMPTOMS { get; set; }
        public string BEATE_HEART { get; set; }
        public string BLOOD_PRESSURE { get; set; }
        public string MAMILLA { get; set; }
        public string MILK { get; set; }
        public string BOTTOM_HEIGHT { get; set; }
        public string ABDOMEN { get; set; }
        public string PERINEUM { get; set; }
        public string COLOUR { get; set; }
        public string AMOUNT { get; set; }
        public string TASTE { get; set; }
        public string PISS { get; set; }
        public string URINARY_TUBE { get; set; }
        public string EXHAUST { get; set; }
        public string OTHER { get; set; }
        public string SIGNATURE { get; set; }
        public Nullable<short> PROCESSING_STATUS { get; set; }
        public string OPERATE_TYPE { get; set; }
        public string CREATE_USER { get; set; }
        public Nullable<System.DateTime> CREATE_TIME { get; set; }
        public string UPDATE_USER { get; set; }
        public Nullable<System.DateTime> UPDATE_TIME { get; set; }
        public Nullable<int> CONSCIOUS_SYMPTOMS_NO { get; set; }
        public Nullable<int> BEATE_HEART_NO { get; set; }
        public Nullable<int> BLOOD_PRESSURE_NO { get; set; }
        public Nullable<int> MAMILLA_NO { get; set; }
        public Nullable<int> MILK_NO { get; set; }
        public Nullable<int> BOTTOM_HEIGHT_NO { get; set; }
        public Nullable<int> ABDOMEN_NO { get; set; }
        public Nullable<int> PERINEUM_NO { get; set; }
        public Nullable<int> COLOUR_NO { get; set; }
        public Nullable<int> AMOUNT_NO { get; set; }
        public Nullable<int> TASTE_NO { get; set; }
        public Nullable<int> PISS_NO { get; set; }
        public Nullable<int> URINARY_TUBE_NO { get; set; }
        public Nullable<int> EXHAUST_NO { get; set; }
        public Nullable<int> OTHER_NO { get; set; }
        public Nullable<int> SIGNATURE_NO { get; set; }
    }
}
