using Cassandra;
using System;
using System.Linq;

namespace CassandraAndDotnetCore
{
    class Program
    {
        static void Main(string[] args)
        {

            Cluster cluster = Cluster.Builder().AddContactPoint("127.0.0.1").Build();


            ISession session = cluster.Connect("phuxingdb");

            var DataList = session.Execute("select * from customer").ToList();

            foreach (var item in DataList) 
            {
               Console.WriteLine("Id : {0} FullName : {1} {2} ", item["id"].ToString(), item["name"], item["surname"]);
            }

            Console.ReadLine();
        }
    }
}




































