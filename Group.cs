using System;

namespace serialization
{
    public class Group
    {
        private readonly Random rnd = new Random(DateTime.Now.Millisecond);
        public int Number { get; set; }
        public string Name { get; set; }

        public Group()
        {
            Number = rnd.Next(1, 10);
            Name = "Группа" + rnd;
        }

        public Group(string name, int number)
        {
            Number = number;
            Name = name;
        }

        public Group(int name, int toInt32)
        {
            Number = rnd.Next(1, 10);
            Name = "Группа" + rnd;
        }

        public override string ToString()
        {
            return Number.ToString();
        }
    }
}