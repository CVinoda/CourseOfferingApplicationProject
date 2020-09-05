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
             List<CoOrdinatorView> coOrdinatoList = new List<CoOrdinatorView>();
            foreach(var course in courses)
            {
                CoOrdinatorView coOrdinatoview = new CoOrdinatorView();
                List<User> members = new List<User>();
                coOrdinatoview.CourseName = course.Name;
                coOrdinatoview.CourseDescription = course.Description;
                var teachers = (from m in members
                                where m.Role.Role1 == "Teacher" select m).ToList();
                var students = (from m in members
                                where m.Role.Role1 == "Student" select m).ToList();
                coOrdinatoview.Teachers = string.Join(",", teachers);
                coOrdinatoview.Students= string.Join(",", students);
                coOrdinatoList.Add(coOrdinatoview);
            }
             return coOrdinatoList;
         }
    }
}.