using System;

namespace serialization
{
    [Serializable]
    public class Group
    {
        [NonSerialized]
        private readonly Random rnd = new Random(DateTime.Now.Millisecond);

        private int privateint;
        
        public int Number { get; set; }
        public string Name { get; set; }
        public Group group { get; set; }

        public Group()
        {
            Number = rnd.Next(1, 10);
            Name = "Группа" + rnd;
            privateint = rnd.Next();
        }

        public Group(int number, string name)
        {
            Number = number;
            Name = name;
            privateint = rnd.Next();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}