using TeachingWebSite.Contracts;
namespace TeachingWebSite.Models;

public class Student : BaseEntity<int>
{
    public Name StudentName { get; set; }
}