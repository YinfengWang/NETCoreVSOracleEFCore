using App.Core;
using System;
namespace App.Data.Entity
{
    /// <summary>
    /// ÆÀ¹ÀÖ÷¼ÇÂ¼±í
    /// </summary>
    public partial class DOC_RECORDS : BaseEntity
    {
        public string ID { get; set; }
        public string PATIENT_ID { get; set; }
        public string VISIT_ID { get; set; }
        public string WARD_CODE { get; set; }
        public int TEMPLATE_ID { get; set; }
        public Nullable<System.DateTime> SCORE_DATE { get; set; }
        public Nullable<short> TOTAL_SCORE { get; set; }
        public string SCORE_RESULT { get; set; }
        public string SCORE_NURSE { get; set; }
        public string RECORD_STATUS { get; set; }
        public string IS_HAPPENED { get; set; }
        public string HAPPENED_POSITION { get; set; }
        public string ASSESS_NURSE { get; set; }
        public Nullable<System.DateTime> ASSESS_DATE { get; set; }
        public string NURSING_CLASS { get; set; }
        public string UPDATER_ID { get; set; }
        public Nullable<System.DateTime> UPDATE_DATE { get; set; }
        public string REMIND_ID { get; set; }
        public string DELAY_STATUS { get; set; }
        public Nullable<short> DELAY_HOURS { get; set; }
        public string EXAMINE_ID { get; set; }
        public Nullable<System.DateTime> EXAMINE_DATE { get; set; }
        public string NURSE_CODE { get; set; }
        public string OPERATE_TYPE { get; set; }
    }
}
