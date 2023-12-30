using Domain.Entities.Base;
using Domain.ValueObjects;

namespace Domain.Entities;

public class Person : BaseEntity
{
    public Email Email { get; private set; }
    public string Name { get; private set; }

    private Person() { }

    public Person
    (
        Guid id,
        DateTimeOffset createdAtUTC,
        Email email,
        string name,
        DateTimeOffset? updatedAtUTC = null
    ) : base(id, createdAtUTC, updatedAtUTC)
    {
        Email = email;
        Name = name;
    }

    public override string ToString()
    {
        return $"Id: {Id} | Email: {Email}";
    }
}
