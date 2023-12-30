using MediatR;

namespace WebApi.Endpoints.People.Create;

public class CreatePersonHandler : IRequestHandler<CreatePersonRequest>
{
    public async Task Handle(CreatePersonRequest request, CancellationToken cancellationToken)
    {
        await Task.CompletedTask;
    }
}
