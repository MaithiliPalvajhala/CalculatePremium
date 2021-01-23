﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CalculatePremium.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class TAL_PremimumEntities : DbContext
    {
        public TAL_PremimumEntities()
            : base("name=TAL_PremimumEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<Nullable<decimal>> sp_GetOccupationRateFactor(string occupation)
        {
            var occupationParameter = occupation != null ?
                new ObjectParameter("occupation", occupation) :
                new ObjectParameter("occupation", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("sp_GetOccupationRateFactor", occupationParameter);
        }
    
        public virtual ObjectResult<DBOccupations_list> sp_getOccupations()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DBOccupations_list>("sp_getOccupations");
        }
    }
}
