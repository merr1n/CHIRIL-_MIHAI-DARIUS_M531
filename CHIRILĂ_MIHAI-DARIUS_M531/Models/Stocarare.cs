namespace CHIRILĂ_MIHAI_DARIUS_M531.Models
{
    static class Stocarare
    {
        static List<Banca> banci = new List<Banca>{new Banca(new Guid("d38df84d-ed5c-44fc-b955-8e7c348fcfc8"), "banca1", new Adresa(new Guid("d93fbff3-634e-4889-b4b3-eebaf119636a"), "adresabanca1", 1, "banca1"), new List<Client>{new Client(new Guid("53759379-6990-48f1-ae33-c3dfc16cd406"), "client1", "client1prenume", "18.02.2000", new Adresa(new Guid("7f7c5550-869c-4308-808f-530119c292ef"), "stradaclient1", 2, "apclient1"), "tip1"),
            new Client(new Guid("8f65fc5a-5552-4731-9a63-5e9a518b3ae3"), "client2", "client2prenume", "01.12.1999", new Adresa(new Guid("54c7de9c-471d-434f-a214-5f6872defef0"), "stradaclient2", 2, "apclient2"), "tip2") }, 280),
            new Banca(new Guid("919f99f6-c763-4f70-bc3f-64ac4049d4cd"), "banca2", new Adresa(new Guid("364f32d8-ed8a-48fb-84f8-973653605d6f"), "adresabanca2", 2, "banca2"), new List<Client>{new Client(new Guid("df13d357-8d70-4064-be39-bbca6e1a2e57"), "client3", "client3prenume", "18.02.2010", new Adresa(new Guid("182c48ed-954e-4e99-8d38-c4bfec741751"), "stradaclient3", 3, "apclient3"), "tip3"),
            new Client(new Guid("8ccb2eb7-3120-4e37-98e0-cf68f187aaf6"), "client4", "client4prenume", "02.02.2002", new Adresa(new Guid("acb737c6-a8ce-411b-9fc2-746892dad344"), "stradaclient4", 4, "apclient4"), "tip4") }, 420) };
    }
}
