using Carter;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Endpoints.People.Create;

public class CreatePeopleEndpoint : CarterModule
{
    public override void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapPost("api/people", HandleAsync)
            .WithTags("people")
            .WithOpenApi();
    }

    private async Task<Results<NoContent, BadRequest>> HandleAsync(
        [FromServices] ISender _sender,
        [FromBody] CreatePeopleRequest request,
        HttpContext context,
        CancellationToken cancellationToken
    )
    {
        await _sender.Send(request, cancellationToken);
        return TypedResults.NoContent();
    }
}
