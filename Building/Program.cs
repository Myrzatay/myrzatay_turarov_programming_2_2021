using System;

namespace Building
{
    public class Builder
    {
        public virtual void Build(){
            Console.WriteLine("Building...");
        }        

    }

    public class HouseBuilder: Builder
    {
        public override void Build()
        {
            Console.WriteLine("Building a house");
        }
    }
    public class DamBuilder: Builder
    {
        public override void Build()
        {
            Console.WriteLine("Build a dam on a river");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Builder b1 = new HouseBuilder();
            Builder b2 = new DamBuilder();
            b1.Build();
            b2.Build();
        }
    }
}
