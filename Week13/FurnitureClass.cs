using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week13
{
    class ArtdecoChair : AbstractChair
    {
        public override void Interact(AbstractSofa sofa)
        {
            Console.WriteLine(this + " interacts with " + sofa);
        }
        public override void Interact(AbstractCoffeeTable table)
        {
            Console.WriteLine(this + " interacts with " + table);
        }
    }
    class ArtdecoSofa : AbstractSofa 
    {
        public override void Interact(AbstractChair chair)
        {
            Console.WriteLine(this + " interacts with " + chair);
        }
        public override void Interact(AbstractCoffeeTable table)
        {
            Console.WriteLine(this + " interacts with " + table);
        }
    }

    class ArtdecoTable : AbstractCoffeeTable 
    {
        public override void Interact(AbstractSofa sofa)
        {
            Console.WriteLine(this + " interacts with " + sofa);
        }
        public override void Interact(AbstractChair chair)
        {
            Console.WriteLine(this + " interacts with " + chair);
        }
    }

    class ArtdecoFactory : AbstractFactory
    {
        public override AbstractSofa CreateSofa()
        {
            return new ArtdecoSofa();
        }
        public override AbstractChair CreateChair()
        {
            return new ArtdecoChair();
        }
        public override AbstractCoffeeTable CreateCoffeeTable()
        {
            return new ArtdecoTable();
        }
    }


    class VictorianChair : AbstractChair
    {
        public override void Interact(AbstractSofa sofa)
        {
            Console.WriteLine(this + " interacts with " + sofa);
        }
        public override void Interact(AbstractCoffeeTable table)
        {
            Console.WriteLine(this + " interacts with " + table);
        }
    }
    class VictorianSofa : AbstractSofa
    {
        public override void Interact(AbstractChair chair)
        {
            Console.WriteLine(this + " interacts with " + chair);
        }
        public override void Interact(AbstractCoffeeTable table)
        {
            Console.WriteLine(this + " interacts with " + table);
        }
    }

    class VictorianTable : AbstractCoffeeTable
    {
        public override void Interact(AbstractSofa sofa)
        {
            Console.WriteLine(this + " interacts with " + sofa);
        }
        public override void Interact(AbstractChair chair)
        {
            Console.WriteLine(this + " interacts with " + chair);
        }
    }

    class VictorianFactory : AbstractFactory
    {
        public override AbstractSofa CreateSofa()
        {
            return new ArtdecoSofa();
        }
        public override AbstractChair CreateChair()
        {
            return new ArtdecoChair();
        }
        public override AbstractCoffeeTable CreateCoffeeTable()
        {
            return new ArtdecoTable();
        }
    }


    class ModernChair : AbstractChair
    {
        public override void Interact(AbstractSofa sofa)
        {
            Console.WriteLine(this + " interacts with " + sofa);
        }
        public override void Interact(AbstractCoffeeTable table)
        {
            Console.WriteLine(this + " interacts with " + table);
        }
    }
    class ModernSofa : AbstractSofa
    {
        public override void Interact(AbstractChair chair)
        {
            Console.WriteLine(this + " interacts with " + chair);
        }
        public override void Interact(AbstractCoffeeTable table)
        {
            Console.WriteLine(this + " interacts with " + table);
        }
    }

    class ModernTable : AbstractCoffeeTable
    {
        public override void Interact(AbstractSofa sofa)
        {
            Console.WriteLine(this + " interacts with " + sofa);
        }
        public override void Interact(AbstractChair chair)
        {
            Console.WriteLine(this + " interacts with " + chair);
        }
    }

    class ModernFactory : AbstractFactory
    {
        public override AbstractSofa CreateSofa()
        {
            return new ArtdecoSofa();
        }
        public override AbstractChair CreateChair()
        {
            return new ArtdecoChair();
        }
        public override AbstractCoffeeTable CreateCoffeeTable()
        {
            return new ArtdecoTable();
        }
    }

    public class Client
    {
        private AbstractSofa sofa;
        private AbstractChair chair;
        private AbstractCoffeeTable table;
        public Client(AbstractFactory factory)
        {
            sofa = factory.CreateSofa();
            chair = factory.CreateChair();
            table = factory.CreateCoffeeTable();
        }
        public void Run()
        {
            sofa.Interact(chair);
        }
    }


}
