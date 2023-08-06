using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 移除指定对象
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> list = new List<Animal>();

            Pig p = new Pig();
            Cat c = new Cat();
            Dog d = new Dog();

            string str = c.Name;

            list.Add(p);
            list.Add(c);
            list.Add(d);

            foreach (Animal a in list)
            {
                a.Call();
            }

            Console.WriteLine("***************");

            list.Remove(c);

            foreach (Animal a in list)
            {
                a.Call();
            }

            Console.WriteLine("***************");
            Console.ReadKey();

        }
    }

    public class Animal
    {
        public string Name
        {
            get;
            set;
        }

        public Animal()
        {
            Name = "动物";
        }

        public Animal(string name)
        {
            Name = name;
        }

        public void Call()
        {
            Console.WriteLine("我叫" + Name.ToString());
        }
    }

    public class Pig : Animal
    {
        public Pig()
            : base("猪")
        { }
    }

    public class Cat : Animal
    {
        public Cat()
            : base("猫")
        { }
    }

    public class Dog : Animal
    {
        public Dog()
            : base("狗")
        { }
    }
}
