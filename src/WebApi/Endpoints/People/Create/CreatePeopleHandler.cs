using MediatR;

namespace WebApi.Endpoints.People.Create;

public class CreatePeopleHandler : IRequestHandler<CreatePeopleRequest>
{
    public async Task Handle(CreatePeopleRequest request, CancellationToken cancellationToken)
    {
        await Task.CompletedTask;
    }
}
