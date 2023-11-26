namespace TaskAutomation.Domain.Abstract;

public abstract class BaseEntity : IBaseEntity
{
    public Guid Id { get; set; }
}