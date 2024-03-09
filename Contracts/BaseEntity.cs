namespace TeachingWebSite.Contracts;

public abstract class BaseEntity<T>
{
    public T Id { get; set; }
    public DateTime CreateDateTime { get; set; }
}