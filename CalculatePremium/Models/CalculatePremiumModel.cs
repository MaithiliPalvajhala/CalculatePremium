using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.SqlClient;
using System.Text;
using System.Data.Entity.Core.Objects;
using System.Web.Http.Cors;

namespace CalculatePremium.Models
{
    public class CalculatePremiumModel
    {
        TAL_PremiumEntities premEntities = new TAL_PremiumEntities();

        public decimal GetOccupationFactor(string occupation)
        {
            try
            {
                // localDB call
                // var result = premEntities.sp_GetOccupationRateFactor(occupation);
                var result = premEntities.sp_GetOccupationRateFactorAzure(occupation);
                return (decimal)result.FirstOrDefault();
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public List<string> getOccupationsfromDB()
        {
            try
            {
                var results = premEntities.sp_getOccupations();
                //local DB call
                //IEnumerable<DBOccupations_list> occupationsObjects = results.ToList<DBOccupations_list>();
                List<string> occupationsList = results.ToList<string>();
                return occupationsList; 
            }
            catch (Exception ex)
            {
                return new List<string>();
            }
        }
    }
}