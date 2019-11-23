using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Private_Lessons.Models;
using Microsoft.EntityFrameworkCore;



namespace Private_Lessons
{
    
       
public class Program
{
public static void Main(string[] args)
{
using (var db = new entitycoreContext())
{
// Creating a new item and saving it to the database
var newItem = new subject();

       
     
         string choose;
        Console.WriteLine("Options:"); 
        Console.WriteLine("1.Login\n2.Register\n3.Search For Topics");
        choose=Console.ReadLine();

          switch (choose)
          {
              
              
     case "1":    
Console.WriteLine("Login Steps:");
Console.WriteLine("Enter Your User Name:");
var x=Console.ReadLine();
Console.WriteLine("Enter Your Password:");
var y=Console.ReadLine();

    var user=db.users.ToArray();
   
    var flag=0;
    var num=0;
   
    for (int i = 0; i < user.Length; i++)
    {
        if(user[i].username==x && user[i].password==y){
             flag=i;
             
        
        }

    }
 
    if(flag !=0){
        Console.WriteLine("Hello : "+user[flag].username);

        //student data
        if(user[flag].type_id==3)
        {
        var stu =db.student_subject_registration.Where(s=> s.student_id==user[flag].id).Include(entry=>entry.subject);
        var user_teacher=db.users.Where(s=>s.type_id==2);  

       Console.WriteLine("Student:"+user[flag].username);
        Console.WriteLine("Registerd Courses:");   
         foreach(var temp in stu)
            {
               Console.WriteLine("_____________");
            Console.WriteLine("Name:{0}\nDate:{1}\nPrice:{2}\nPlace:{3}\nGrade:{4}",temp.subject.name,temp.subject.date,temp.subject.price,temp.subject.place,temp.grade);
         
            }   
        }
        //teacher Data
      if(user[flag].type_id==2){
     var teach=db.subject_teachers.Where(s=>s.teacher_id==user[flag].id).Include(entry4=>entry4.subject);
      Console.WriteLine("Teacher:"+user[flag].username);
           Console.WriteLine("My Courses");
            foreach(var item in teach){ 
                Console.WriteLine("Name:{0}\nDate:{1}\nPlace:{2}\nPrice:{3}",item.subject.name,item.subject.date,item.subject.place,item.subject.price);
                  Console.WriteLine("__________");
            }
      }  

    }else{
        Console.WriteLine("Invalid user");
    }
    break;
     

     
     //registration
       case "2":    
     Console.WriteLine("1.Student\n2.Teacher");
     string member;
     member=Console.ReadLine();
  
          if(member=="1"){
         Console.WriteLine("User Name:");
         string userName=Console.ReadLine();
       Console.WriteLine("First Name:");
         string firstName=Console.ReadLine(); 
       Console.WriteLine("Last Name:");
         string lastName=Console.ReadLine();
     Console.WriteLine("Email:");
         string newEmail=Console.ReadLine(); 
         Console.WriteLine("Password:");
         string newPassword=Console.ReadLine();
      db.users.Add(new users{username=userName,password=newPassword,f_name=firstName,l_name=lastName,email=newEmail,type_id=3});  
      db.SaveChanges(); 
      Console.WriteLine("Successfully Registered ");  
          }
          if(member=="2"){
            Console.WriteLine("User Name:");
         string userName=Console.ReadLine();
       Console.WriteLine("First Name:");
         string firstName=Console.ReadLine(); 
       Console.WriteLine("Last Name:");
         string lastName=Console.ReadLine();
     Console.WriteLine("Email:");
         string newEmail=Console.ReadLine(); 
         Console.WriteLine("Password:");
         string newPassword=Console.ReadLine();
      db.users.Add(new users{username=userName,password=newPassword,f_name=firstName,l_name=lastName,email=newEmail,type_id=2});  
      db.SaveChanges(); 
     Console.WriteLine("Successfully Registered "); 
          
          }
          else{
            Console.WriteLine("Invalid option");
          }
        
       
     
   break;







case "3":
    //searching for sbject
         Console.WriteLine("Search For Subject:");
         var xsub=Console.ReadLine();
    var sub=db.subject.Where(s=>s.name==xsub).ToArray();

   
   

    for (int i = 0; i < sub.Length; i++)
    {
       
        Console.WriteLine("Name:{0}\nDate:{1}\nPlace:{2}\nPrice:{3}",sub[i].name,sub[i].date,sub[i].place,sub[i].price);
        var subid=sub[i].id;
        var subt=db.subject_teachers.Where(e=>e.subject_id==subid).ToArray();
          Console.WriteLine("Teachers:");
        for (int j = 0; j < subt.Length; j++)
        {
           var teach=db.users.Where(t=>t.id==subt[j].teacher_id).ToArray();
         
              for (int k = 0; k < teach.Length; k++)
              {
                Console.WriteLine("-{0} {1}",teach[k].f_name,teach[k].l_name);  
              }
            
        } 
 
    }
    break;
 
 
   }//swich end




}
}
}
}