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
    
    public partial class tblMainMenu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblMainMenu()
        {
            this.tblSubMenus = new HashSet<tblSubMenu>();
        }
    
        public int Id { get; set; }
        public string MainMenu { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSubMenu> tblSubMenus { get; set; }
    }
}