namespace Prototype
{
    public class ConcretePrototypeA : Prototype
    {
        public ConcretePrototypeA(string name) : base(name)
        {
        }

        public override Prototype Clone()
        {
            return (Prototype)MemberwiseClone();
        }
    }
}
