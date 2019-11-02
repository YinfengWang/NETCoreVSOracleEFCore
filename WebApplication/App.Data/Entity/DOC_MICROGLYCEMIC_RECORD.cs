using App.Core;
using System;
namespace App.Data.Entity
{

    /// <summary>
    /// Î¢Á¿ÑªÌÇ¼à²â±í
    /// </summary>
    public partial class DOC_MICROGLYCEMIC_RECORD : BaseEntity
    {
        public  string ID { get; set; }
        public string NURSE_CODE { get; set; }
        public string PATIENT_ID { get; set; }
        public string VISIT_ID { get; set; }
        public string NURSING_CLASS { get; set; }
        public Nullable<System.DateTime> TEST_TIME { get; set; }
        public string ENTRY_TIME { get; set; }
        public string GLUCSE_PRICE { get; set; }
        public string SIGNATURE { get; set; }
        public Nullable<short> PROCESSING_STATUS { get; set; }
        public string OPERATE_TYPE { get; set; }
        public string CREATE_USER { get; set; }
        public Nullable<System.DateTime> CREATE_TIME { get; set; }
        public string UPDATE_USER { get; set; }
        public Nullable<System.DateTime> UPDATE_TIME { get; set; }
    }
}
