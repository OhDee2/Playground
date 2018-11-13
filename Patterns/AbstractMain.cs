﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Patterns
{
    public class AbstractMain
    {
        public static void Main()
        {
            AbstractFactory factory1 = new ConcreteFactory1();
            Client client1 = new Client(factory1);
            client1.Run();

            AbstractFactory factory2 = new ConcreteFactory2();
            Client client2 = new Client(factory2);
            client2.Run();


            Console.ReadKey();
        }

        abstract class AbstractFactory
        {
            public abstract AbstractProductA CreateProductA();
            public abstract AbstractProductB CreateProductB();
        }

        private class ConcreteFactory1 : AbstractFactory
        {
            public override AbstractProductA CreateProductA()
            {
                return new ProductA1();
            }

            public override AbstractProductB CreateProductB()
            {
                return new ProductB1();
            }
        }

        private class ConcreteFactory2 : AbstractFactory
        {
            public override AbstractProductA CreateProductA()
            {
                return new ProductA2();
            }

            public override AbstractProductB CreateProductB()
            {
                return new ProductB2();
            }
        }

        abstract class AbstractProductA
        {

        }

        abstract class AbstractProductB
        {
            public abstract void Interact(AbstractProductA a);
        }

        private class ProductA1 : AbstractProductA
        {

        }

        private class ProductA2 : AbstractProductA
        {

        }

        private class ProductB1 : AbstractProductB
        {
            public override void Interact(AbstractProductA a)
            {
                Console.WriteLine(this.GetType().Name +
                                  " interacts with " + a.GetType().Name);
            }
        }

        private class ProductB2 : AbstractProductB
        {
            public override void Interact(AbstractProductA a)
            {
                Console.WriteLine(this.GetType().Name +
                                  " interacts with " + a.GetType().Name);
            }
        }

        private class Client
        {
            private AbstractProductA _abstractProductA;
            private AbstractProductB _abstractProductB;

            public Client(AbstractFactory factory)
            {
                _abstractProductB = factory.CreateProductB();
                _abstractProductA = factory.CreateProductA();
            }

            public void Run()
            {
                _abstractProductB.Interact(_abstractProductA);
            }

        }
    }
}
