using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace Algorithms
{
    public class WebRequestAlgorithms
    {
        public static void CallService()
        {
            HttpWebRequest request = WebRequest.Create("https://jsonmock.hackerrank.com/api/article_users/search?page?2") as HttpWebRequest;

            var result = "";
            using (var response = (HttpWebResponse)request.GetResponse())
            {
                var encoding = Encoding.GetEncoding(response.CharacterSet);

                using (var responseStream = response.GetResponseStream())
                using (var reader = new StreamReader(responseStream, encoding))
                    result = reader.ReadToEnd();
            }

            try
            {
                var result2 = JsonConvert.DeserializeObject<ApiResult>(result); 
            }
            catch (Exception e)
            {
                //msg
                throw e;
            }
        }
    }

    public class ApiResult
    {
        public int page { get; set; }
        public int per_page { get; set; }
        public int total { get; set; }
        public List<User> data { get; set; }
    }

    public class User
    {
        public int id { get; set; }
        public string username { get; set; }
        public string about { get; set; }
        public int submitted { get; set; }
        public DateTime updated_at { get; set; }
        public int submission_count { get; set; }
        public int comment_count { get; set; }
        public int created_at { get; set; }
    }
}
