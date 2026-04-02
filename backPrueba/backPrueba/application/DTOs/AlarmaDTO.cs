namespace backPrueba.application.DTOs
{
    public record AlarmaDTO(
        Guid id,
        string emisor,
        DateTime fecha,
        bool activacion
    );
}
