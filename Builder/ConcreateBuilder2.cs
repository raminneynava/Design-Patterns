namespace Builder
{
    public class ConcreateBuilder2: Builder
    {
        public override void BuildCategory()
        {
            product.Category = "Cat2";
        }

        public override void BuildPrice()
        {
            product.Price = "200000";
        }

        public override Product GetResult()
        {
            product.Name = "Product 2";
            Console.WriteLine($"{product.Name} is Created");
            return base.GetResult();
        }
    }
}
