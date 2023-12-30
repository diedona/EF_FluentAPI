using MediatR;

namespace WebApi.Endpoints.People.Create;

public record CreatePeopleRequest 
(
    string Name,
    string EmailAddress
) : IRequest;
