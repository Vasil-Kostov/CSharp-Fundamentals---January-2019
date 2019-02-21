namespace _08._Pet_Clinic
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            List<Pet> pets = new List<Pet>();
            List<Clinic> clinics = new List<Clinic>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "Create")
                {
                    if (command[1] == "Pet")
                    {
                        pets.Add(new Pet(command[2], int.Parse(command[3]), command[4]));
                    }
                    else
                    {
                        try
                        {
                            clinics.Add(new Clinic(command[2], int.Parse(command[3])));
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
                else if (command[0] == "Add")
                {
                    var pet = pets.Find(p => p.Name == command[1]);

                    Console.WriteLine(clinics.Find(c => c.Name == command[2]).Add(pet));
                }
                else if (command[0] == "Release")
                {
                    Console.WriteLine(clinics.Find(c => c.Name == command[1]).Release());
                }
                else if (command[0] == "HasEmptyRooms")
                {
                    Console.WriteLine(clinics.Find(c => c.Name == command[1]).HasEmptyRooms());
                }
                else
                {
                    if (command.Length == 3)
                    {
                        clinics.Find(c => c.Name == command[1]).Print(int.Parse(command[2]));
                    }
                    else
                    {
                        clinics.Find(c => c.Name == command[1]).Print();
                    }
                }
            }
        }
    }
}
