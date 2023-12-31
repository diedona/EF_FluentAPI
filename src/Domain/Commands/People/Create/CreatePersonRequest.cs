using MediatR;

namespace Domain.Commands.People.Create;

public record CreatePersonRequest
(
    string Name,
    string EmailAddress
) : IRequest;
