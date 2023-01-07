namespace HousingSocietyManagement.Models
{
    public class HousingSocietyRepository : IHousingSociety
    {
        private static List<Flat> flats = new List<Flat>()
        {
            new Flat(){FlatNo = 123,FlatName="A-123",FlatOwner = "Rajen",Wing = "A",Mobile = 7894561236,Aadhar = 78945123678964565,Email = "Rajen@gmail.com"},
            new Flat(){FlatNo = 2,FlatName="B-2",FlatOwner = "Geetha",Wing = "B",Mobile = 9874563215,Aadhar = 741258963258,Email = "Geetha@gmail.com"}
        };

        public Flat GetFlatById(int flatNo)
        {
            Flat flat = flats.Find(x => x.FlatNo == flatNo);
            return flat;
        }

        public List<Flat> GetFlats()
        {
            return flats;
        }

        public void AddNewFlat(Flat flat)
        {
            flats.Add(flat);
        }

        public void DeleteFlat(int flatNo)
        {
            throw new NotImplementedException();
        }

        public void EditFlat(int flatNo,string wing)
        {
            throw new NotImplementedException();
        }
    }
}
