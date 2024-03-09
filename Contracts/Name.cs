namespace TeachingWebSite.Contracts;

public abstract class Name
{
    public string NamePrefix { get; set; }
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
    public string NameSuffix { get; set; }
}