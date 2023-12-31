using MediatR;

namespace Domain.Commands.People.Create;

public class CreatePersonHandler : IRequestHandler<CreatePersonRequest>
{
    public async Task Handle(CreatePersonRequest request, CancellationToken cancellationToken)
    {
        await Task.CompletedTask;
    }
}
