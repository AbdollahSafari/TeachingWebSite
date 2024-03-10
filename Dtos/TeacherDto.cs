using TeachingWebSite.Contracts;

namespace TeachingWebSite.Dtos
{
    public class TeacherDto
    {
        public int Id { get; set; }
        public  Name Name{ get; set; }
        public int ClassPricePerHour { get; set; }
    }
}
