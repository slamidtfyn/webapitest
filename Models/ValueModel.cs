namespace dnc7.Models
{

    public class ValueModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Values Value { get; set; }


    }

    public enum Values { Yes, No }
}