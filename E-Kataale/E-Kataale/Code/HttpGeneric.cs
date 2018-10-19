using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace E_Kataale.Code
{
    public class HttpGeneric
    {

        public async Task<string> GetAsync(string url)
        {

            WebRequest webRequest = WebRequest.Create(url);

            WebResponse response = webRequest.GetResponse();


            StreamReader reader = new StreamReader(response.GetResponseStream());


            return reader.ReadLine();

        }

        public async Task PostAsync(string url, JObject Data)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
           
            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {               
                streamWriter.Write(Data);
                streamWriter.Flush();
                streamWriter.Close();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }


        }

        public async Task PutAsync(string url, JObject Data)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "PUT";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(Data);
                streamWriter.Flush();
                streamWriter.Close();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }

        }

        public async Task DeleteAsync(string url)
        {
            WebRequest webRequest = WebRequest.Create(url);

            webRequest.Method = "DELETE";

            WebResponse response = webRequest.GetResponse();


            StreamReader reader = new StreamReader(response.GetResponseStream());
            
        }

    }
}