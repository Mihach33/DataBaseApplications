using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace APBD2
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!args[2].Equals("json"))
            {
                throw new Exception("nie mozna zapisac dane w ten format");

            }
            List<Student> students = new List<Student>();
            try
            {
                using (StreamReader sr = new StreamReader(args[0]))
                {
                    while (sr.Peek() >= 0)
                    {
                        bool notFull = false;
                        string line = sr.ReadLine();
                        string[] infos = line.Split(",");

                        if (infos.Length != 9)
                        {
                            StreamWriter sw = new StreamWriter(@"C:\Users\Mihach\Desktop\APBD\rep\cwiczenia2_zen-s20511\APBD2\APBD2\Data\logs.txt", true);
                            sw.WriteLine("lBlad - student {" + line + "} jest pominiety, nie ma 9 kolumn z informacja");
                            sw.Close();
                            continue;
                        }

                        for (var i = 0; i < infos.Length; i++)
                        {
                            if (!(infos[i] != "" || infos[i] == null))
                            {
                                notFull = true;
                                break;
                            }

                        }
                        if (notFull)
                        {
                            StreamWriter sw = new StreamWriter(@"C:\Users\Mihach\Desktop\APBD\rep\cwiczenia2_zen-s20511\APBD2\APBD2\Data\logs.txt", true);
                            sw.WriteLine("Blad - student {" + line + "} jest pominiety, nie ma wszystkiej informacji");
                            sw.Close();
                            continue;
                        }

                        Student student = new Student
                        {
                            firstName = infos[0],
                            lastName = infos[1],
                            faculty = infos[2],
                            mode = infos[3],
                            idStudent = int.Parse(infos[4]),
                            birthDay = infos[5],
                            mail = infos[6],
                            motherName = infos[7],
                            fatherName = infos[8]
                        };
                        students.Add(student);
                    }

                    string ser = JsonSerializer.Serialize(students);
                    //File.WriteAllText(args[1], ser);
                }
            }
            catch (FileNotFoundException e)
            {
                
                StreamWriter sw = new StreamWriter(@"C:\Users\Mihach\Desktop\APBD\rep\cwiczenia2_zen-s20511\APBD2\APBD2\Data\logs.txt", true);
                sw.WriteLine("Plik nazwa nie istnieje");
                sw.Close();
            }
            catch (ArgumentException e)
            {
                StreamWriter sw = new StreamWriter(@"C:\Users\Mihach\Desktop\APBD\rep\cwiczenia2_zen-s20511\APBD2\APBD2\Data\logs.txt", true);
                sw.WriteLine("Podana ścieżka jest niepoprawna");
                sw.Close();
            }
        }
    }
}
