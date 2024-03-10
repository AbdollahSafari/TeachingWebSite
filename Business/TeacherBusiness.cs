using TeachingWebSite.Contracts;
using TeachingWebSite.Models;

namespace TeachingWebSite.Business
{
    public class TeacherBusiness : ITeacherBusiness
    {
        static public List<Teacher> Teachers = new List<Teacher>()
        {
            new Teacher()
            {
                Id = 1, ClassPricePerHour = 10, CreateDateTime = DateTime.Now, IsActive = true,
                TeacherName = new Name(){FirstName = "first1", LastName = "last1"}, 
            },
            new Teacher()
            {
                Id = 1, ClassPricePerHour = 10, CreateDateTime = DateTime.Now, IsActive = true,
                TeacherName = new Name(){FirstName = "first2", LastName = "last2"},
            },
            new Teacher()
            {
                Id = 1, ClassPricePerHour = 10, CreateDateTime = DateTime.Now, IsActive = true,
                TeacherName = new Name(){FirstName = "first3", LastName = "last3"},
            },
            new Teacher()
            {
                Id = 1, ClassPricePerHour = 10, CreateDateTime = DateTime.Now, IsActive = true,
                TeacherName = new Name(){FirstName = "first4", LastName = "last4"},
            },
        };

        public List<Teacher> GetTeacher()
        {
            return Teachers;
        }

        public Teacher GetTeacherById(int id)
        {
            var teacher = Teachers.FirstOrDefault(x => x.Id == id);
            return teacher;
        }

        public bool AddTeacher(Teacher teacher)
        {
            Teachers.Add(teacher);
            return true;
        }
    }
}
