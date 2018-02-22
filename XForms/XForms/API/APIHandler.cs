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
        private string Base_URL = "http://jsonplaceholder.typicode.com/posts";//
        //private string Base_URL = "https://reqres.in/api/";
        private readonly HttpClient _client = new HttpClient(); //Creating a new instance of HttpClient. (Microsoft.Net.Http)

        Exception InnerMostException;
        string Exception_Messages;
        int ExceptionCount = 0;

        //public IEnumerable<Customer> findAll()
        public async Task<string> findAll()
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
            catch (Exception e)///// This while loop catch was prepared as the app was throwing message "One or more exception has occured "
            {
                InnerMostException = e;//Initially assign first caught exception object, This will be used in case if there is no inner exception
                ExceptionCount = 0;
                ++ExceptionCount;
                Exception_Messages = ExceptionCount + InnerMostException.GetType().ToString() + "  =[" + InnerMostException.Message + "] ";
                while (InnerMostException.InnerException != null)
                {
                    ++ExceptionCount;
                    InnerMostException = InnerMostException.InnerException;
                    Exception_Messages = Exception_Messages + "\n" + ExceptionCount + InnerMostException.GetType().ToString() + "  =[" + InnerMostException.Message + "] ";
                }
                return Exception_Messages;// false;
            }


            //string content = await _client.GetStringAsync(Base_URL); //Sends a GET request to the specified Uri and returns the response body as a string in an asynchronous operation
            ////List<Post> posts = JsonConvert.DeserializeObject<List<Post>>(content); //Deserializes or converts JSON String into a collection of Post
            ////_posts = new ObservableCollection<Post>(posts); //Converting the List to ObservalbleCollection of Post
            ////MyListView.ItemsSource = _posts; //Assigning the ObservableCollection to MyListView in the XAML of this file
            //return content;
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
                InnerMostException = e;//Initially assign first caught exception object, This will be used in case if there is no inner exception
                ExceptionCount = 0;
                ++ExceptionCount;
                Exception_Messages = ExceptionCount + InnerMostException.GetType().ToString() + "  =[" + InnerMostException.Message + "] ";
                while (InnerMostException.InnerException != null)
                {
                    ++ExceptionCount;
                    InnerMostException = InnerMostException.InnerException;
                    Exception_Messages = Exception_Messages + "\n" + ExceptionCount + InnerMostException.GetType().ToString() + "  =[" + InnerMostException.Message + "] ";
                }
                return Exception_Messages;// false;
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
                InnerMostException = e;//Initially assign first caught exception object, This will be used in case if there is no inner exception
                ExceptionCount = 0;
                ++ExceptionCount;
                Exception_Messages = ExceptionCount + InnerMostException.GetType().ToString() + "  =[" + InnerMostException.Message + "] ";
                while (InnerMostException.InnerException != null)
                {
                    ++ExceptionCount;
                    InnerMostException = InnerMostException.InnerException;
                    Exception_Messages = Exception_Messages + "\n" + ExceptionCount + InnerMostException.GetType().ToString() + "  =[" + InnerMostException.Message + "] ";
                }
                return Exception_Messages;// false;
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
                InnerMostException = e;//Initially assign first caught exception object, This will be used in case if there is no inner exception
                ExceptionCount = 0;
                ++ExceptionCount;
                Exception_Messages = ExceptionCount + InnerMostException.GetType().ToString() + "  =[" + InnerMostException.Message + "] ";
                while (InnerMostException.InnerException != null)
                {
                    ++ExceptionCount;
                    InnerMostException = InnerMostException.InnerException;
                    Exception_Messages = Exception_Messages + "\n" + ExceptionCount + InnerMostException.GetType().ToString() + "  =[" + InnerMostException.Message + "] ";
                }
                return Exception_Messages;// false;
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
            catch (Exception e)
            {
                InnerMostException = e;//Initially assign first caught exception object, This will be used in case if there is no inner exception
                ExceptionCount = 0;
                ++ExceptionCount;
                Exception_Messages = ExceptionCount + InnerMostException.GetType().ToString() + "  =[" + InnerMostException.Message + "] ";
                while (InnerMostException.InnerException != null)
                {
                    ++ExceptionCount;
                    InnerMostException = InnerMostException.InnerException;
                    Exception_Messages = Exception_Messages + "\n" + ExceptionCount + InnerMostException.GetType().ToString()+"  =[" + InnerMostException.Message + "] ";
                }
                return Exception_Messages;// false;
            }
        }
    }


}
