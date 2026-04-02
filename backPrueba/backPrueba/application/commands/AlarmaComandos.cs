using MediatR;

namespace backPrueba.application.commands
{
    public record AlarmaComandos(string emisor) : IRequest<Guid>;
}
