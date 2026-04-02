using backPrueba.domain.entities;

namespace backPrueba.application.interfaces
{
    public interface IAlarmaRepository
    {
        Task GuardarAlarma(Alarma alarma); 
        Task<IEnumerable<Alarma>> ObtenerAlarmas();
    }
}
