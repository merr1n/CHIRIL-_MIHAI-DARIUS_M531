namespace CHIRILĂ_MIHAI_DARIUS_M531.Models
{
    public class Adresa
    {
        public Adresa(Guid id, string strada, int numar, string apartament)
        {
            Id = id;
            Strada = strada;
            Numar = numar;
            Apartament = apartament;
        }

        public Guid Id {  get; set; }
        public string Strada { get; set; }
        public int Numar { get; set; }
        public string Apartament { get; set;
        }
    }
}
