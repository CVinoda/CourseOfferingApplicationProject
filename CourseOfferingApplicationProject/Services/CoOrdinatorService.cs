using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CourseOfferingApplicationProject.Models;
using CourseOfferingApplicationProject.ViewModels;
using Microsoft.Ajax.Utilities;

namespace CourseOfferingApplicationProject.Services
{
    public class CoOrdinatorService
    {
        private CourseOfferingDBContext dbContext;
         public  List<CoOrdinatorView> GetCoOrdinator()
         {

             List<Cours> courses = new List<Cours>();
            foreach(var course in courses)
            {
                CoOrdinatorView coOrdinator = new CoOrdinatorView();
                List<User> members = new List<User>();
                coOrdinator.CourseName = course.Name;
                coOrdinator.CourseDescription = course.Description;
                var teachers = (from m in members
                                where m.Role.Role1 == "Teacher" select members);
                coOrdinator.Teachers = string.Join(",", teachers.ToArray());
            }
             //var courselist= dbContext.Courses.Select(x=>x).ToList();
             //var couseUserslist= dbContext.CourseXUsers.Select(x=>x).ToList();
             //             var users= dbContext.Users.Select(x=>x).ToList();

             //var recs = from c in couseUserslist
             //           join cl in courselist
             //               on c.CourseId equals cl.ID
             //           //join user in users on c.UserId equals user.UserId
             //           select new CoOrdinatorView
             //                      {
             //                          CourseName = cl.Name,
             //                          CourseDescription = cl.Description,

             //                      };
             //return recs.ToList();

         }
    }
}.