using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace MidtermWS
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service1 : System.Web.Services.WebService
    {

        [WebMethod]
        public List<Route> GetRoutes()
        {
            List<Route> answer = new List<Route>();
            return answer;
        }

        [WebMethod]
        public List<Venue> GetVenues()
        {
            List<Venue> answer = new List<Venue>();
            return answer;
        }

        [WebMethod]
        public bool CreateRoute()
        {
            try
            {

            }
            catch (Exception)
            {
                
                return false;
            }
            return true;
        }

        [WebMethod]
        public bool CheckIn()
        {
            try
            {

            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }
    }

    public class Route
    {
        string name;
        int ID;
        double price;
    }

    public class Venue
    {
        int ID;
        string name;
    }
}