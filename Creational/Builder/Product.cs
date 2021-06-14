using System;
using System.Collections.Generic;

namespace Builder
{
    public class Product
    {
        public List<string> Parts { get; } = new List<string>();

        public void Add(string part)
        {
            Parts.Add(part);
        }

        public void Show()
        {
            Parts.ForEach(Console.WriteLine);
        }
    }
}
