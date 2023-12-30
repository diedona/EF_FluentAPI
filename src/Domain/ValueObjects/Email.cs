namespace Domain.ValueObjects
{
    public record Email(string Address, bool Verified = false)
    {
        public string Address { get; init; } = Address.ToLowerInvariant();
    }
}
