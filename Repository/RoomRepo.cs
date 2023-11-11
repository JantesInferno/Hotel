using System;
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
    }
}
