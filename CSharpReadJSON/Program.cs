
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpReadJSON
{
    class Program
    {
        static void Main(string[] args)
        {



            using (StreamReader file = File.OpenText(@"C:\Users\bilge.adam\source\repos\CSharpReadJSON\CSharpReadJSON\users.json"))
            {
                using (JsonTextReader reader = new JsonTextReader(file))
                {
                    JObject o2 = (JObject)JToken.ReadFrom(reader);

                    JToken kullanicilar = o2["users"];

                    List<User> csharpusers = new List<User>();
                    foreach (var item in kullanicilar)
                    {
                        User newuser = new User();

                        newuser.Name = item["name"].ToString();
                        newuser.City = item["city"].ToString();
                        newuser.EMail = item["email"].ToString();
                        newuser.Phone = item["phone"].ToString();
                        
                        newuser.RegisterDate = DateTime.ParseExact(item["registerdate"].ToString(), "dd/mm/yy", null);

                        csharpusers.Add(newuser);

                    }
                }

            }

            Console.ReadLine();
        }
    }
}
