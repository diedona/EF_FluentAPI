using Carter;
using Domain.Commands.People.Create;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Endpoints.People.Create;

public class CreatePersonEndpoint : CarterModule
{
    public override void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapPost("api/people", HandleAsync)
            .WithTags("people")
            .WithOpenApi();
    }

    private async Task<Results<NoContent, BadRequest>> HandleAsync(
        [FromServices] ISender _sender,
        [FromBody] CreatePersonRequest request,
        HttpContext context,
        CancellationToken cancellationToken
    )
    {
        await _sender.Send(request, cancellationToken);
        return TypedResults.NoContent();
    }
}
