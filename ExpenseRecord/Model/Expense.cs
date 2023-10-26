using Newtonsoft.Json;

namespace ExpenseRecord.Model
{
    public class Expense
    {
       // [JsonProperty(PropertyName = "id")]
        public int id { get; set; }
        //[JsonProperty(PropertyName = "description")]
        public string description { get; set; }
       // [JsonProperty(PropertyName = "type")]
        public string type { get; set; }
       // [JsonProperty(PropertyName = "amount")]
        public decimal amount { get; set; }
       // [JsonProperty(PropertyName = "date")]
        public DateTime date { get; set; }

        public Expense(int id , string des, string type, decimal amo, DateTime date)
        {
            this.id = id;
            this.description = des;
            this.type = type;
            this.amount = amo;
            this.date = date;

        }
    }
}
