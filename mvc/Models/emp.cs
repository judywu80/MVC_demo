//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace mvc.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class emp
    {
        public int eno { get; set; }
        public string ename { get; set; }
        public string sex { get; set; }
        public string job { get; set; }
        public Nullable<int> mgr { get; set; }
        public Nullable<System.DateTime> hiredate { get; set; }
        public int sal { get; set; }
        public Nullable<int> comm { get; set; }
        public Nullable<int> dno { get; set; }
    
        public virtual dept dept { get; set; }
    }
}
