using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CalculatePremium.Models;
using System.Data.SqlClient;
using System.Text;
using System.Data.Entity.Core.Objects;
using System.Web.Http.Cors;

namespace CalculatePremium.Controllers
{
    public class CalculatePremiumController : ApiController
    {
        CalculatePremiumModel calcPremModel = new CalculatePremiumModel();
        [HttpGet]
       [ActionName("GetOccupationFactor")]
       [EnableCors(origins: "*", headers: "*", methods: "*")]
        public decimal GetOccupationFactor(string Occupation)
        {
            try
            {
                var Factor = calcPremModel.GetOccupationFactor(Occupation);
                return (decimal)Factor;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        [HttpGet]
        [ActionName("GetOccupations")]
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public List<string> getOccupations()
        {
            List<string> occ = calcPremModel.getOccupationsfromDB();
            return occ;
        }




    }
}
