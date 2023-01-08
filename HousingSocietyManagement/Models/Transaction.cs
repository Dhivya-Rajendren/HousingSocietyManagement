namespace HousingSocietyManagement.Models
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public DateTime TransactionDate { get; set; }

        public int FlatNo { get; set; }

        public Flat Flat { get; set; }

        public int MaintenanceId { get; set; }
        public Maintenance Maintenance { get; set; }
        public int TransactionAmount { get; set; }
    }
}
