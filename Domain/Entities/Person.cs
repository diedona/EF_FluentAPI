using Domain.Entities.Base;
using Domain.ValueObjects;

namespace Domain.Entities;

public class Person(
        Guid id,
        DateTimeOffset createdAtUTC,
        Email email,
        string name,
        DateTimeOffset? updatedAtUTC = null
    ) : BaseEntity(id, createdAtUTC, updatedAtUTC)
{
    public Email Email { get; private set; } = email;
    public string Name { get; private set; } = name;

    public override string ToString()
    {
        return $"Id: {Id} | Email: {Email}";
    }
}
