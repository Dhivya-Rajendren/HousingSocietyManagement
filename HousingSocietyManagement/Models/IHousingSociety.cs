namespace HousingSocietyManagement.Models
{
    public interface IHousingSociety
    {
        List<Flat> GetFlats();
        Flat GetFlatById(int flatNo);

        void AddNewFlat(Flat flat);

        void DeleteFlat(int flatNo);

        void EditFlat(int flatNo,string wing);

    }
}
