namespace Domain.Entities.Base;

public abstract class BaseEntity
{
    public Guid Id { get; protected set; }
    public DateTimeOffset CreatedAtUTC { get; protected set; }
    public DateTimeOffset? UpdatedAtUTC { get; protected set; }

    protected BaseEntity(Guid id, DateTimeOffset createdAtUTC, DateTimeOffset? updatedAtUTC = null)
    {
        Id = id;
        CreatedAtUTC = createdAtUTC;
        UpdatedAtUTC = updatedAtUTC;
    }
}
