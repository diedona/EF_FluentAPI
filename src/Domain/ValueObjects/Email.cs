namespace Domain.ValueObjects
{
    public record Email(string Address, bool Verified)
    {
        public string Address { get; init; } = Address.ToLowerInvariant();
    }
}
