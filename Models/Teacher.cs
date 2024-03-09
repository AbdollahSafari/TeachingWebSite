using TeachingWebSite.Contracts;

namespace TeachingWebSite.Models;

public class Teacher : BaseEntity<int>
{
    public Name TeacherName { get; set; }
    public int ClassPricePerHour { get; set; }
    public bool IsActive { get; set; }
}