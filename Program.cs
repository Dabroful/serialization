﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace serialization
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var groups = new List<Group>();
            var students = new List<Student>();
            for (int i = 0; i < 10; i++)
            {
                groups.Add(new Group(i, "Группа" + i));
            }

            for (int i = 0; i < 300; i++)
            {
                var student = new Student(Guid.NewGuid().ToString().Substring(0, 5), i % 100)
                {
                    Group = groups[i % 9]
                };

                students.Add(student);
            }

            var binFormatter = new BinaryFormatter();
            using (var file = new FileStream("groups.txt", FileMode.OpenOrCreate))                  //записываем в файл данные. Это и есть сериализация
            {
                binFormatter.Serialize(file, groups);
            }
            
        }
    }
}