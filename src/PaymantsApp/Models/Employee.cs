namespace PaymantsApp.Models
{
    public class Employee : BaseModel
    {
        public string Name { get; set; }
        public decimal Wallet { get; set; }
        public List<Paymant> Paymants { get; set; }=new List<Paymant>();






    }
}