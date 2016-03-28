using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeStudentCourses
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void assignment1Button_Click(object sender, EventArgs e)
        {
            List<Course> courses = new List<Course>()
            {
                new Course() { CourseId = 1, Name = "Econ 101", Students = new List<Student>()
                {
                        new Student() { StudentId = 1, Name = "Matthew J Pearson"},
                        new Student() { StudentId = 2, Name = "Roman Baraowitz"}}
                },
                new Course() { CourseId = 2, Name = "Discrete Math", Students = new List<Student>()
                {
                        new Student() { StudentId = 3, Name = "Geoff Notsayer"},
                        new Student() { StudentId = 4, Name = "Thomas Belldiller"}}
                },
                new Course() { CourseId = 3, Name = "American History", Students = new List<Student>()
                {
                        new Student() { StudentId = 5, Name = "Talon Burkwhey"},
                        new Student() { StudentId = 6, Name = "Jordy Backfall"}}
                }      
            };

            foreach (var course in courses)
            {
                resultLabel.Text += String.Format("</br>Course:{0} - {1}", course.CourseId, course.Name);
                foreach (var student in course.Students)
                {
                    resultLabel.Text += String.Format("</br>&nbsp;&nbsp;Student: {0} - {1}", student.StudentId, student.Name);
                }
            }
        }

        protected void assignment2Button_Click(object sender, EventArgs e)
        {        
            Course course1 = new Course() { CourseId = 1, Name = "Algebra 3" };
            Course course2 = new Course() { CourseId = 2, Name = "Phychology" };
            Course course3 = new Course() { CourseId = 3, Name = "Business Law"};

            Dictionary<int, Student> students = new Dictionary<int, Student>()
            {
                {1, new Student { StudentId = 1, Name = "Matthew J Pearson", Courses = new List<Course> { course1, course2} } },
                {2, new Student { StudentId = 2, Name = "Lambeau Hutchings", Courses = new List<Course> { course2, course3} } },
                {3, new Student { StudentId = 3, Name = "Lombardy Diego", Courses = new List<Course> {course1, course2 } } }
            };

            foreach (var student in students)
            {
                resultLabel.Text += String.Format("</br>{0} {1}", student.Value.StudentId, student.Value.Name);
                foreach (var course in student.Value.Courses)
                {
                    resultLabel.Text += String.Format("</br>Course: &nbsp;&nbsp;{0} {1}", course.Name, course.CourseId);
                } 
            }
        }

        protected void assignment3Button_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.StudentId = 10;
            student.Name = "Bete Makey";
            student.Enrollments = new List<Enrollment>()
            {
                 new Enrollment { Grade = 92, Course = new Course { CourseId = 1, Name = "Phychology 101" }},
                 new Enrollment { Grade = 96, Course = new Course { CourseId = 2, Name = "Project Management 342" }}
            };

            resultLabel.Text += String.Format("</br>Student: {0} {1}", student.StudentId, student.Name);
            foreach (var enrollment in student.Enrollments)
            {
                resultLabel.Text += String.Format("</br>Enrolled in: {0} - Grade: {1}", enrollment.Course.Name, enrollment.Grade);
            }
        }
    }
}