using CHIRILĂ_MIHAI_DARIUS_M531.Models;

namespace CHIRILĂ_MIHAI_DARIUS_M531.Services
{
    public interface IGeneralServices
    {
        void MoveClient(Banca banca1, Banca banca2, Guid idClient);
        int SameClient(List<Banca> banci, Guid idClient);
    }
}
