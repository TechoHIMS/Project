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
    
    public partial class TBL_CONSULTANT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_CONSULTANT()
        {
            this.TBL_R_RECEIPT = new HashSet<TBL_R_RECEIPT>();
        }
    
        public int CON_JOB_ID { get; set; }
        public string CON_NAME { get; set; }
        public Nullable<int> CON_FEE { get; set; }
        public Nullable<int> CD { get; set; }
        public Nullable<int> CTFEE { get; set; }
        public string DEGREE { get; set; }
        public Nullable<int> ER_FEE { get; set; }
        public Nullable<int> SP_VISIT { get; set; }
        public Nullable<int> STATUS { get; set; }
        public Nullable<int> FELLOW_UP { get; set; }
        public string DESG { get; set; }
        public Nullable<int> DOC_SHARE { get; set; }
        public Nullable<int> DEP_ID { get; set; }
    
        public virtual TBL_R_DEPT TBL_R_DEPT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_R_RECEIPT> TBL_R_RECEIPT { get; set; }
    }
}
