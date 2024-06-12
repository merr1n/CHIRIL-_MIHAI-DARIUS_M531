using CHIRILĂ_MIHAI_DARIUS_M531.Models;

namespace CHIRILĂ_MIHAI_DARIUS_M531.Services
{
    public interface IBankService
    {
        void AddClient(Banca banca, Client client);
        void RemoveClient(Banca banca, Guid clientId);
        void UpdatedData(Banca banca, Adresa adresa, string nume);
        void DisplayClients(Banca banca);
        List<Client> FilterClients(Banca banca, string filter, string filterInput);

    }
}
