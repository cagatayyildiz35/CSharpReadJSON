using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
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
            using (StreamReader file = File.OpenText(@"C:\Users\bilge.adam\source\repos\CSharpReadJSON\CSharpReadJSON\products.json"))
            {
                using (JsonTextReader reader = new JsonTextReader(file))
                {
                    JObject o2 = (JObject)JToken.ReadFrom(reader);

                    JToken urunler = o2["urunler"];


                    foreach (var item in urunler)
                    {
                        string name = item["name"].ToString();
                        double price = Convert.ToDouble(item["price"]);
                    }
                }

            }

            Console.ReadLine();
        }
    }
}
