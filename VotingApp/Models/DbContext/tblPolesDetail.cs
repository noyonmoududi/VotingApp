//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VotingApp.Models.DbContext
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblPolesDetail
    {
        public int Id { get; set; }
        public Nullable<int> PolesId { get; set; }
        public string OptionText { get; set; }
        public string ImagePath { get; set; }
    
        public virtual tblPole tblPole { get; set; }
    }
}
