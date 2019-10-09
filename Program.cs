using System;

namespace Private_Lessons
{
    class Program
    {
        static void Main(string[] args)
        {
           using(var db=new Models.PLSDbcontext()){
                db.Database.EnsureCreated();
                Console.WriteLine("Completily Created :)");
           }
        }
    }
}
