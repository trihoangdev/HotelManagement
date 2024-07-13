using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.ClassFolder
{
    public class Room
    {
        public string Id { get; set; }
        public string Type { get; set; }  //loại phòng (VD: Standard, Deluxe, Suite)
        public int Capacity { get; set; }   //sức chứa
        public Double Price { get; set; }//Giá phòng/đêm
        public string Status { get; set; }  //Tình trạng phòng (VD: Trống, Đã đặt, Đang bảo trì)
        public string Description { get; set; }//mô tả phòng
        public Room() { }
        public Room(string id, string type, int capacity, double price, string status, string description)
        {
            Id = id;
            Type = type;
            Capacity = capacity;
            Price = price;
            Status = status;
            Description = description;
        }

    }
}
