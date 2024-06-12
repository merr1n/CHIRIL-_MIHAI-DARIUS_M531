using CHIRILĂ_MIHAI_DARIUS_M531.Models;

namespace CHIRILĂ_MIHAI_DARIUS_M531.Services
{
    public class GeneralServices : IGeneralServices
    {
        public void MoveClient(Banca banca1, Banca banca2, Guid idClient)
        {
            for(int i=0;i<banca1.Clienti.Count;i++)
            {
                Client client = banca1.Clienti[i];
                if(client.Id == idClient)
                {
                    banca1.Clienti.Remove(client);
                    banca2.Clienti.Add(client);
                }
            }
        }

        public int SameClient(List<Banca> banci, Guid idClient)
        {
            int counter = 0;
            for(int i=0;i<banci.Count;i++)
            {
                Banca banca = banci[i];
                for(int j = 0; j < banca.Clienti.Count;j++)
                {
                    Client client = banca.Clienti[j];
                    if (client.Id==idClient)
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }
    }
}
