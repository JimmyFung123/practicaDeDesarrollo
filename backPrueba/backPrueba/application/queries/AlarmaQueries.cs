using backPrueba.application.DTOs;
using MediatR;

namespace backPrueba.application.queries
{
    public record AlarmaQueries() : IRequest<IEnumerable<AlarmaDTO>>;
}
