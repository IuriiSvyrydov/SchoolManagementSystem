namespace Core.Abstractions;

public abstract class Entity
{

    private readonly List<IDomainEvent> _domainEvents = new();
    public Guid Id { get; set; }

    protected Entity()
    {
        
    }

    public Entity(Guid id)
    {
        Id = id;
    }

    public IReadOnlyCollection<IDomainEvent> GetAllDomainEvent()
    {
        return _domainEvents.ToList();
    }
    public void AddDomainEvent(IDomainEvent domainEvent)
    {
        _domainEvents.Add(domainEvent);
    }

    public void ClearDomainEvent()
    {
        _domainEvents.Clear();
    }


    
}