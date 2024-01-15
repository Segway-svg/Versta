using API.Models;
using Newtonsoft.Json;
using System.Linq.Expressions;
using System.Net;

namespace API
{
    public class APIGateway
    {
        private string url = "http://localhost:5218/api/Order";
        private HttpClient httpClient = new HttpClient();

        public List<Order> ListOrders()
        {
            List<Order> orders= new List<Order>();
            if (url.Trim().Substring(0, 5).ToLower() == "http")
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            try
            {
                HttpResponseMessage response = httpClient.GetAsync(url).Result;
                if (response.IsSuccessStatusCode)
                {
                    string result = response.Content.ReadAsStringAsync().Result;
                    var datacol = JsonConvert.DeserializeObject<List<Order>>(result);
                    if (datacol != null)
                        orders = datacol;
                }
                else
                {
                    string result = response.Content.ReadAsStringAsync().Result;
                    throw new Exception("Error Occured at the API Endpoint. Error Info. " + result);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error Occured at the API Endpoint, Error Info. " + ex.Message);
            }

            finally { }
            return orders;
        }
    }
}
