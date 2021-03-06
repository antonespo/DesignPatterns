﻿using System;
using System.Collections.Generic;

namespace SOLID_principles
{
    class Program
    {
        static void Main(string[] args)
        {
            // Liskov Substitution

            Shape circle = new Circle(2, 3, 4);
            circle.PrintParameters();

            // Open-Closed Principle

            //var apple = new Product("Apple", Color.Green, Size.Small);
            //var tree = new Product("Tree", Color.Green, Size.Large);
            //var house = new Product("House", Color.Blue, Size.Large);

            //Product[] products = { apple, tree, house };

            //var pf = new ProductFilter();
            //Console.WriteLine("Green products: ");
            //foreach (var p in pf.FilterByColor(products, Color.Green))
            //{
            //    Console.WriteLine($" - {p.Name} is green");
            //}

            //var filter = new SpecificationFilter();
            //Console.WriteLine("Green products: ");
            //foreach (var p in filter.Filter(products, new ColorSpecification(Color.Green)))
            //{
            //    Console.WriteLine($" - {p.Name} is green");
            //}

            //Console.WriteLine("Green and large products: ");
            //foreach (var p in filter.Filter(
            //    products,
            //    new AndSpecification<Product>(new ColorSpecification(Color.Green), new SizeSpecification(Size.Large))))
            //{
            //    Console.WriteLine($" - {p.Name} is green and large");
            //}
        }
    }
}
