using CHIRILĂ_MIHAI_DARIUS_M531.Models;

namespace CHIRILĂ_MIHAI_DARIUS_M531.Services
{
    public class BankService : IBankService
    {
        public void AddClient(Banca banca, Client client)
        {
            banca.Clienti.Add(client);
        }

        public void RemoveClient(Banca banca, Guid clientId) 
        {
            for(int i=0;i<banca.Clienti.Count;i++)
            {
                Client client = banca.Clienti[i];
                if(client.Id==clientId)
                    banca.Clienti.Remove(client);
            }
        }

        public void UpdatedData(Banca banca, Adresa adresa, string nume)
        {
            banca.Adresa = adresa;
            banca.Nume = nume;
        }

        public void DisplayClients(Banca banca)
        {
            for(int i = 0; i < banca.Clienti.Count; i++)
            {
                Client client = banca.Clienti[i];
                
            }
        }

        public List<Client> FilterClients(Banca banca, string filter, string filterInput)
        {
            List<Client> clienti = new List<Client>();
            if(filter=="nume")
            {
                for(int i=0;i<banca.Clienti.Count;i++)
                {
                    Client client = banca.Clienti[i];
                    if (client.Nume == filterInput)
                        clienti.Add(client);
                }
            }
            if(filter=="adresa")
            {
                for(int i=0;i<banca.Clienti.Count;i++)
                {
                    Client client = banca.Clienti[i];
                    if (client.Adresa.Strada == filterInput)
                        clienti.Add(client);
                }
            }
            if(filter=="tip_credit")
            {
                for(int i=0;i<banca.Clienti.Count;i++)
                {
                    Client client = banca.Clienti[i];
                    if (client.Tip_credit == filterInput)
                        clienti.Add(client);
                }
            }
            return clienti;
        }
    }
}
