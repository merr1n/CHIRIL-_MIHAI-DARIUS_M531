namespace CHIRILĂ_MIHAI_DARIUS_M531.Models
{
    public class Client
    {
        public Client(Guid id, string nume, string prenume, string data_nasterii, Adresa adresa, string tip_credit)
        {
            Id = id;
            Nume= nume;
            Prenume= prenume;
            Data_nasterii= data_nasterii;
            Adresa = adresa;
            Tip_credit= tip_credit;
        }

        public Guid Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Data_nasterii { get; set; }
        public Adresa Adresa { get; set; }
        public string Tip_credit { get; set;}

    }
}
