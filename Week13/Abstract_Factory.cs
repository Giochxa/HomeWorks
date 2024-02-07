using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week13
{
    public abstract class AbstractFactory
    {
        public abstract AbstractChair CreateChair();
        public abstract AbstractSofa CreateSofa();
        public abstract AbstractCoffeeTable CreateCoffeeTable();
    }
    public abstract class AbstractChair
    {
        public abstract void Interact(AbstractCoffeeTable table);
        public abstract void Interact(AbstractSofa sofa);
    }
    public abstract class AbstractSofa
    {
        public abstract void Interact(AbstractChair chair);
        public abstract void Interact(AbstractCoffeeTable table);
    }
    public abstract class AbstractCoffeeTable
    {
        public abstract void Interact(AbstractChair chair);
        public abstract void Interact(AbstractSofa sofa);
    }

}
