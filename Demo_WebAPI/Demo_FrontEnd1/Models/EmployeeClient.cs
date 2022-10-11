using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace Demo_FrontEnd1.Models
{
    public class EmployeeClient
    {
        // private string Base URL =""
        private string Base_Url = "https://localhost:44302/api/";

        // GET: Employees
        public IEnumerable<EmployeeModel> Find()
        {
            try
            {

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(Base_Url);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("aplication/json"));
                HttpResponseMessage message = client.GetAsync("EMP_RIDHI_FIFTEEN/").Result;
                if (message.IsSuccessStatusCode)
                {
                    return message.Content.ReadAsAsync<IEnumerable<EmployeeModel>>().Result;
                }
                return null;
            }
            catch (Exception)
            {
                return null;
                //throw;
            }
            
        }
        public IEnumerable<EmployeeModel> FindID(string id)
        {
            try
            {

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(Base_Url);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("aplication/json"));
                HttpResponseMessage message = client.GetAsync("EMP_RIDHI_FIFTEEN/" + id.ToString()).Result;
                if (message.IsSuccessStatusCode)
                {
                    return message.Content.ReadAsAsync<IEnumerable<EmployeeModel>>().Result;
                }
                return null;
            }
            catch (Exception)
            {
                return null;
                //throw;
            }

        }
        public bool Delete(string id)
        {
            try
            {

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(Base_Url);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("aplication/json"));
                HttpResponseMessage message = client.DeleteAsync("EMP_RIDHI_FIFTEEN/" + id).Result;
                return (message.IsSuccessStatusCode);
            }
            catch (Exception)
            {
                return false;
                //throw;
            }

        }
    }
}