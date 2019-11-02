using App.Core;
using System;

namespace App.Data.Entity
{
    /// <summary>
    /// 发送报告的中间表
    /// </summary>
    public partial class MNIS_T_REPORT_DATA : BaseEntity
    {
        public string ID { get; set; }
        public Nullable<System.DateTime> CREATE_DATE { get; set; }
        public string STATUS { get; set; }
        public string ERROR_MSG { get; set; }
        public string UPDATE_FLAG { get; set; }
        public string XML_URL { get; set; }
        public string PDF_URL { get; set; }
        public string PATIENT_ID { get; set; }
        public string VISIT_ID { get; set; }
        public string PATIENT_NAME { get; set; }
        public string REPORT_NO { get; set; }
        public string REPORT_TYPE { get; set; }
        public Nullable<System.DateTime> REPORT_DATE { get; set; }
        public Nullable<System.DateTime> VALID_DATE { get; set; }
        public string PAGE_ORENTION { get; set; }
        public string PAGE_SIZE { get; set; }
        public string PAGE_COUNT { get; set; }
        public string PUBLISH_SYSTEM { get; set; }
        public string CREATE_DEPT { get; set; }
        public string TYPE { get; set; }
    }
}
