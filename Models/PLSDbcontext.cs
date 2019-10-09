
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Private_Lessons.Models
{
    public class PLSDbcontext:DbContext
    {

        public PLSDbcontext (DbContextOptions<PLSDbcontext> options) : base (options) { }
        public PLSDbcontext(){}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      {
               
                  SqlConnectionStringBuilder ConnectionString=new SqlConnectionStringBuilder()
                  {

                      DataSource= @"*",  //server name
                      InitialCatalog="PrivateLessons",   //database name
                      IntegratedSecurity=true, //windows authentication
                  };
                  
          optionsBuilder.UseSqlServer(ConnectionString.ToString());
          
      }





    }
}