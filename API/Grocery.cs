namespace MyAPI.Data.Models

{
    public class Grocery
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";

        public Grocery(int id, string name)
        {
            Id = id;
            Name = name;

        }

        public static List<Grocery> GetItems() => new List<Grocery>
        {
            new Grocery(0, "eggs" ),
            new Grocery(1, "milk"),
            new Grocery(2, "bread"),
            new Grocery(3, "cheese"),
            new Grocery(4, "flour"),
            new Grocery(5, "soda"),
            new Grocery(6, "toothpaste")
        };
    }
}
