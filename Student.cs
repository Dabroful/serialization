﻿namespace serialization
{
    public class Student
    {
       public string Name { get; }
       public int Age { get; }

       public Student(string name, int age)
       {
           Name = name;
           Age = age;
       }

       public override string ToString()
       {
           return Name;
       }
    }
}