using System;

namespace Hotel
{
    public class Hotel
    {
        public uint RoomCount { get; set; }
        public uint OccupiedRooms { get; set; }



        public Hotel(uint initialRoomCount)
        {
            if (initialRoomCount < 1 || initialRoomCount > 1000)
            {
                throw new ArgumentException("Комнат должно быть от 1 до 1000");
            }

            RoomCount = initialRoomCount;
        }

        public void CheckIn()
        {
            if (OccupiedRooms < RoomCount)
            {
                OccupiedRooms++;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Нет свободных комнат");
            }
        }

        public void CheckOut()
        {
            if (OccupiedRooms > 0)
            {
                OccupiedRooms--;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Нет комнат для выселения");
            }
        }


    }
}
