//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RestaurantProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class TotalCommandes
    {
        public int Id { get; set; }
        public Nullable<int> Num_commande { get; set; }
        public Nullable<System.DateTime> Jours { get; set; }
        public Nullable<int> Num_table { get; set; }
        public Nullable<decimal> Prix { get; set; }
        public Nullable<int> id_serveur { get; set; }
        public Nullable<decimal> gain_serveur { get; set; }
    
        public virtual Serveur Serveur { get; set; }
        public virtual Tables Tables { get; set; }
    }
}