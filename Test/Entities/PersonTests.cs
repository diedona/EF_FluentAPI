using Domain.Entities;
using Domain.ValueObjects;

namespace Test.Entities;

public class PersonTests
{
    [Fact]
    public void TestEmail_ShouldBe_Equal()
    {
        Email email = new("diedona@gmail.com", true);
        Person pessoa = new(Guid.NewGuid(), DateTimeOffset.UtcNow, email, "djego");
        Assert.Equal(pessoa.Email, new("diedona@gmail.com", true));
    }

    [Fact]
    public void TestEmail_ShouldBe_Equal_CaseIsDifferent()
    {
        Email email = new("DieDona@Gmail.com", true);
        Person pessoa = new(Guid.NewGuid(), DateTimeOffset.UtcNow, email, "djego");
        Assert.Equal(pessoa.Email, new("dIedOna@gmaiL.com", true));
    }

    [Fact]
    public void TestEmail_ShouldBe_Different_Verified()
    {
        Email email = new("diedona@gmail.com", true);
        Person pessoa = new(Guid.NewGuid(), DateTimeOffset.UtcNow, email, "djego");
        Assert.NotEqual(pessoa.Email, new("diedona@gmail.com", false));
    }
}
