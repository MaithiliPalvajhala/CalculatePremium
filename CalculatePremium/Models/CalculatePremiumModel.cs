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
        TAL_PremimumEntities premEntities = new TAL_PremimumEntities();

        public decimal GetOccupationFactor(string occupation)
        {
            try
            {
                var result = premEntities.sp_GetOccupationRateFactor(occupation);
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
                IEnumerable<DBOccupations_list> occupationsObjects = results.ToList<DBOccupations_list>();
                List<string> occupations = occupationsObjects.Select(s => s.occupation).ToList();
                return occupations;
            }
            catch (Exception ex)
            {
                return new List<string>();
            }
        }
    }
}