namespace backPrueba.domain.entities
{
    public class Alarma
    {
        public Guid id { get; set; }
        public string emisor { get; set; }
        public DateTime Fecha { get; set; }
        public bool activacion { get; set; }

        public Alarma(string emisor)
        {
            id = Guid.NewGuid();
            this.emisor = emisor;
            fecha = DateTime.Now;
            activacion = false;
        }

        public void activarAlarma()
        {
            activacion = true;
        }
    }
}
