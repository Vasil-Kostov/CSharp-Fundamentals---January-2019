namespace _08._Pet_Clinic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Clinic
    {
        private Pet[] rooms;
        private int midRoomIndex;

        public Clinic(string name, int rooms)
        {
            if (rooms % 2 != 0)
            {
                this.Name = name;
                this.midRoomIndex = rooms / 2;
                this.rooms = new Pet[rooms];
            }
            else
            {
                throw new ArgumentException("Invalid Operation!");
            }
        }

        public bool Add(Pet pet)
        {
            for (int i = 0; i <= this.midRoomIndex; i++)
            {
                if (this.rooms[this.midRoomIndex - i] == null)
                {
                    this.rooms[this.midRoomIndex - i] = pet;
                    return true;
                }

                if (this.rooms[this.midRoomIndex + i] == null)
                {
                    this.rooms[this.midRoomIndex + i] = pet;
                    return true;
                }

            }

            return false;
        }

        public bool Release()
        {
            for (int i = this.midRoomIndex; i < this.rooms.Length; i++)
            {
                if (this.rooms[i] != null)
                {
                    this.rooms[i] = null;
                    return true;
                }
            }

            for (int i = 0; i < this.midRoomIndex; i++)
            {
                if (this.rooms[i] != null)
                {
                    this.rooms[i] = null;
                    return true;
                }
            }

            return false;
        }

        public void Print()
        {
            for (int i = 1; i <= this.rooms.Length; i++)
            {
                this.Print(i);
            }
        }

        public void Print(int room)
        {
            if (this.rooms[room - 1] != null)
            {
                Console.WriteLine(this.rooms[room - 1]);
            }
            else
            {
                Console.WriteLine("Room empty");
            }
        }

        public bool HasEmptyRooms() => this.rooms.Any(r => r == null);

        public string Name { get; set; }
    }
}

