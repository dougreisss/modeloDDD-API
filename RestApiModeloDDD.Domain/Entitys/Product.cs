namespace RestApiModeloDDD.Domain.Entitys
{
    public class Product : Base
    {
        public string Name { get; set; }
        public decimal Value { get; set; }
        public bool Available { get; set; }
    }
}
