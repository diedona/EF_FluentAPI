using MediatR;

namespace WebApi.Endpoints.People.Create;

public record CreatePersonRequest 
(
    string Name,
    string EmailAddress
) : IRequest;
