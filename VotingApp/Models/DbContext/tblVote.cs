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
    
    public partial class tblVote
    {
        public int Id { get; set; }
        public Nullable<int> PolesDetailsId { get; set; }
        public Nullable<long> UserId { get; set; }
        public Nullable<System.DateTime> VoteTime { get; set; }
    }
}
