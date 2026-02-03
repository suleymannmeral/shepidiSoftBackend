using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShepidiSoft.API.Abstraction;
using ShepidiSoft.Application.Features.Activities.Commands.CreateActivity;

namespace ShepidiSoft.API.Controllers;

public sealed class ActivitiesController(IMediator mediator) : BaseApiController(mediator)
{
    [HttpPost]
    public async Task<IActionResult> Create(
CreateActivityCommand request,
CancellationToken cancellationToken)
=> CreateActionResult(await _mediator.Send(request, cancellationToken));

}
