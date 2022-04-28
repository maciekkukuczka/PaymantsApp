namespace PaymantsApp.Models
{
    public class Paymant : BaseModel
    {
        public decimal Value { get; set; }
        public DateTime DateOfPaymant { get; set; }

    }
}