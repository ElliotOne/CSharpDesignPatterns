namespace Builder
{
    public class ConcreteBuilderA : Builder
    {
        public Product Product { get; } = new Product();

        public override void BuildPart1()
        {
            Product.Add("Part 1");
        }

        public override void BuildPart2()
        {
            Product.Add("Part 2");
        }

        public override Product GetResult()
        {
            return Product;
        }
    }
}
