using MediatR;
using backPrueba.domain.entities;
using backPrueba.application.interfaces;
using backPrueba.application.commands;

namespace backPrueba.application.commands
{
    public class AlarmaComandosHandle : IRequestHandler<AlarmaComandos, Guid>
    {
        public readonly IAlarmaRepository _repository;

        public AlarmaComandosHandle(IAlarmaRepository repository)
        {
            _repository = repository;
        }


        public async Task<Guid> Handle(AlarmaComandos request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();

            var nuevaAlarma = new Alarma(request.emisor);

            await _repository.GuardarAlarma(nuevaAlarma);

            return nuevaAlarma.id;
        }

    }
}
