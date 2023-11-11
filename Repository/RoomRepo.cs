﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Repository
{
    public class RoomRepo
    {
        private static readonly DataHandler _db;

        static RoomRepo()
        {
            _db = new DataHandler();
        }

        public static List<Room> GetAllRooms() 
        { 
            return _db.Rooms.ToList();
        }

        public static Room GetRoomByID(int id)
        {
            return _db.Rooms.Include("RoomType").SingleOrDefault(x => x.RoomID == id);
        }

        public static bool CheckRoomAvailability(Room room, DateTime start, DateTime end)
        {
            bool b = _db.Bookings.Include("Rooms").Any(x => x.RoomID == room.RoomID && (x.StartDate <= end || start <= x.EndDate));
            if (b == false)
                return true;

            return false;
        }
    }
}
