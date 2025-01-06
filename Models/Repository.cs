using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1_Asp.Net_MVC.Models
{
    public class Repository
    {
        private static readonly List<Course> _courses = new();
        static Repository()
        {
            _courses = new List<Course>(){
                new Course(){
                    Id=1,
                    Title="Aspnet kursu",
                    Image="1.jpg",
                    Desc="Guzel bir kurs",
                    Tags=new string[]{"Aspnet","Web gelistirme"},
                    IsActive=true,
                    IsHome=true
                },
                new Course(){
                     Id=2,
                      Title="Php kursu",
                     Image="2.jpg",
                      Desc="Guzel bir kurs",
                    IsActive=true,
                    IsHome=false},
                new Course(){
                    Id=3,
                    Title="Django kursu",
                    Image="3.jpeg",
                    Desc="Guzel bir kurs",
                    IsActive=true,
                    IsHome=false},
                new Course(){Id=4,
                     Title="Java kursu",
                     Image="4.jpg",
                      Desc="Guzel bir kurs",
                        Tags=new string[]{"Java","Web gelistirme"},
                        IsActive=true,
                       IsHome=true
                       } 
            };
        }
        public static List<Course> Courses
        {
            get
            {
                return _courses;
            }
        }

        public static Course? GetById(int? id)
        {
            return _courses.FirstOrDefault(c => c.Id == id);
        }
    }
}