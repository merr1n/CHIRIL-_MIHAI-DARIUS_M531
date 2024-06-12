namespace CHIRILĂ_MIHAI_DARIUS_M531.Models
{
    public class Banca
    {
        public Banca(Guid id, string nume, Adresa adresa, List<Client> clienti, float dobanda_generala)
        {
            Id = id;
            Nume = nume;
            Adresa = adresa;
            Clienti = clienti;
            Dobanda_generala = dobanda_generala;
        }

        public Guid Id { get; set; }
        public string Nume { get; set; }
        public Adresa Adresa { get; set; }
        public List<Client> Clienti { get; set; }
        public float Dobanda_generala { get; set; }

        public void ClientiBanca()
        {

        }
    }
}
