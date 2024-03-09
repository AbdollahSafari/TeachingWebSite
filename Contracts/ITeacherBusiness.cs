using TeachingWebSite.Models;

namespace TeachingWebSite.Contracts;

public interface ITeacherBusiness
{
    List<Teacher> GetTeacher();
    Teacher GetTeacherById(int id);
    bool AddTeacher(Teacher teacher);
}