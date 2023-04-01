using System;
using System.Collections.Generic;

namespace serialization
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var groups = new List<Group>();
            for (int i = 0; i < 10; i++)
            {
                groups.Add(new Group(i, Convert.ToInt32("Группа" + i)));
            }
        }
    }
}