using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace XForms.API
{
    class APIHandler
    {
    }
    public class DataAccess
    {
        private string Base_URL = "https://reqres.in/api/";

        //public IEnumerable<Customer> findAll()
        public string findAll()
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(Base_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("users").Result;

                if (response.IsSuccessStatusCode)
                {
                    string JsonString = response.Content.ReadAsStringAsync().Result;
                    //use JavaScriptSerializer from System.Web.Script.Serialization
                    //JavaScriptSerializer JSserializer = new JavaScriptSerializer();
                    //deserialize to your class
                    //return JsonConvert.DeserializeObject<IEnumerable<Customer>>(JsonString);
                    //return JSserializer.Deserialize<IEnumerable<Customer>>(JsonString);
                    return JsonString;
                }
                return null;
            }
            catch (Exception e)
            {
                return e.Message;// false;
            }
        }
        //public Customer find(int id)
        public string find(int id)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(Base_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("users/" + id).Result;

                if (response.IsSuccessStatusCode)
                {

                    string JsonString = response.Content.ReadAsStringAsync().Result;
                    //use JavaScriptSerializer from System.Web.Script.Serialization
                    //JavaScriptSerializer JSserializer = new JavaScriptSerializer();
                    //deserialize to your class
                    //return JsonConvert.DeserializeObject<Customer>(JsonString);
                    //return JSserializer.Deserialize<Customer>(JsonString);
                    return JsonString;
                }
                return null;
            }
            catch (Exception e)
            {
                return e.Message;// false;
            }
        }
        //public bool Create(Customer customer)
        //public bool Create()
        public string Create()
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(Base_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.PostAsync("users", new StringContent(
                    //new JavaScriptSerializer().Serialize(customer)
                    //JsonConvert.SerializeObject(customer)
                    "{'name': 'morpheus','job': 'leader'}"
                    , Encoding.UTF8, "application/json")).Result;
                return response.StatusCode.ToString();// response.IsSuccessStatusCode;
            }
            catch (Exception e)
            {
                return e.Message;// false;
            }
        }
        //public bool Edit(Customer customer)
        //public bool Edit()
        public string Edit()
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(Base_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.PutAsync("users/" + 2, new StringContent(
                    //new JavaScriptSerializer().Serialize(customer)
                    //JsonConvert.SerializeObject(customer)
                    "{'name': 'morpheus','job': 'leader'}"
                    , Encoding.UTF8, "application/json")).Result;
                return response.StatusCode.ToString();// response.IsSuccessStatusCode;
            }
            catch (Exception e)
            {
                return e.Message;// false;
            }
        }
        //public bool Delete(int id)
        public string Delete(int id)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(Base_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.DeleteAsync("users/" + id).Result;
                return response.StatusCode.ToString();// response.IsSuccessStatusCode;
            }
            catch(Exception e)
            {
                return e.Message;// false;
            }
        }
    }


}
