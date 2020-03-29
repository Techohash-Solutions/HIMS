//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_R_PATIENT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_R_PATIENT()
        {
            this.TBL_R_RECEIPT = new HashSet<TBL_R_RECEIPT>();
        }
    
        public Nullable<int> FAMILY_NO { get; set; }
        public Nullable<System.DateTime> TDATE { get; set; }
        public int MR_NO { get; set; }
        public Nullable<int> AGE { get; set; }
        public string FIRST_NAME { get; set; }
        public string ADDRESS1 { get; set; }
        public string STREET_ADDRESS2 { get; set; }
        public string CITY { get; set; }
        public string STATE { get; set; }
        public Nullable<int> POSTAL_CODE { get; set; }
        public Nullable<int> PHONE_NUMBER1 { get; set; }
        public Nullable<int> PHONE_NUMBER2 { get; set; }
        public Nullable<int> CREDIT_LIMIT { get; set; }
        public string EMAIL { get; set; }
        public string GENDER { get; set; }
        public Nullable<int> USERID { get; set; }
        public Nullable<int> ADMINTOTAL { get; set; }
        public Nullable<int> DEPT_ID { get; set; }
        public string F_NAME { get; set; }
        public Nullable<int> PANEL_G { get; set; }
        public Nullable<int> ADDMISSIONID { get; set; }
        public Nullable<int> PMNHP_NO { get; set; }
        public string PROCEDUREGROUP { get; set; }
        public Nullable<int> PATIENTTYPE { get; set; }
        public Nullable<int> PROTOTAL { get; set; }
        public Nullable<int> STATUS { get; set; }
        public Nullable<int> NIC { get; set; }
        public Nullable<System.DateTime> DATEOFBIRTH { get; set; }
        public string SSN { get; set; }
        public string EMG_NAME { get; set; }
        public Nullable<int> EMG_CONTACT { get; set; }
        public string EMG_RELATION { get; set; }
        public Nullable<int> EMG_HOME { get; set; }
        public Nullable<int> EMP_CODE { get; set; }
        public string EMP_NAME { get; set; }
        public string EMP_DESG { get; set; }
        public Nullable<int> EMP_CONTACT { get; set; }
        public Nullable<int> EMP_DEPART { get; set; }
        public string EMP_ADDRESS { get; set; }
        public Nullable<int> POLICY_ID { get; set; }
        public Nullable<System.DateTime> EFFECT_DATE { get; set; }
        public string P_GROUP { get; set; }
        public string P_HOLDER_NAME { get; set; }
        public Nullable<System.DateTime> P_DOB { get; set; }
        public string P_RELATION { get; set; }
        public string P_INSSURANCE { get; set; }
        public string TEL_NO { get; set; }
        public string CNIC_NO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_R_RECEIPT> TBL_R_RECEIPT { get; set; }
    }
}
