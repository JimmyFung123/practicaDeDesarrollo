using MediatR;
using backPrueba.domain.entities;
using backPrueba.application.interfaces;
using backPrueba.application.DTOs;

namespace backPrueba.application.queries
{
    public class AlarmaQueriesHandler: IRequestHandler<AlarmaQueries, IEnumerable<AlarmaDTO>>
    {
        private readonly IAlarmaRepository _repository;

        public AlarmaQueriesHandler(IAlarmaRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<AlarmaDTO>> Handle(AlarmaQueries request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();

            var alarmas = await _repository.ObtenerAlarmas();

            var dtos = alarmas.Select(a => new AlarmaDTO(
                a.id,
                a.emisor,
                a.fecha,
                a.activacion
            ));

            return dtos;
        }
    }
}
