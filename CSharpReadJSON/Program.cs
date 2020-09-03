
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

            var path = @"C:\Users\bilge.adam\Desktop\CagatayBoost\okuyombenya.txt";

            string[] lines = File.ReadAllLines(path, Encoding.UTF8);

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }



            using (StreamReader file = File.OpenText(@"C:\Users\bilge.adam\source\repos\CSharpReadJSON\CSharpReadJSON\firms.json"))
            {
                using (JsonTextReader reader = new JsonTextReader(file))
                {
                    JObject o2 = (JObject)JToken.ReadFrom(reader);

                    JToken firms = o2["firm"];


                    List<Student> students = new List<Student>();

                    foreach (var item in firms)
                    {
                        var data = item["students"];

                        foreach (var item2 in data)
                        {
                            Student student = new Student();
                            student.Name = item2["name"].ToString();
                            student.Surname= item2["surname"].ToString();

                            students.Add(student);
                        }
                    }


                    //List<User> csharpusers = new List<User>();
                    //foreach (var item in kullanicilar)
                    //{
                    //    User newuser = new User();

                    //    newuser.Name = item["name"].ToString();
                    //    newuser.City = item["city"].ToString();
                    //    newuser.EMail = item["email"].ToString();
                    //    newuser.Phone = item["phone"].ToString();
                        
                    //    newuser.RegisterDate = DateTime.ParseExact(item["registerdate"].ToString(), "dd/mm/yy", null);

                    //    csharpusers.Add(newuser);

                    //}
                }

            }

            Console.ReadLine();
        }
    }
}
