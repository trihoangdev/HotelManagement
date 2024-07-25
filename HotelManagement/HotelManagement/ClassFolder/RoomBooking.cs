using System;


namespace HotelManagement.ClassFolder
{
    public class RoomBooking
    {
        public int Id { get; set; }
        public string CustomerId { get; set; }
        public string RoomId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int NumberOfGuests { get; set; }
        public double TotalPrice { get; set; }
        public string BookingStatus { get; set; }
        public string Notes { get; set; }
        public RoomBooking() { }
        public RoomBooking(int id, string customerId, string roomId, DateTime checkInDate, DateTime checkOutDate, int numberOfGuests, double totalPrice, string bookingStatus, string notes)
        {
            Id = id;
            CustomerId = customerId;
            RoomId = roomId;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
            NumberOfGuests = numberOfGuests;
            TotalPrice = totalPrice;
            BookingStatus = bookingStatus;
            Notes = notes;
        }
        public RoomBooking(string customerId, string roomId, DateTime checkInDate, DateTime checkOutDate, int numberOfGuests, double totalPrice, string bookingStatus, string notes)
        {
            Id = GetCurentId();
            CustomerId = customerId;
            RoomId = roomId;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
            NumberOfGuests = numberOfGuests;
            TotalPrice = totalPrice;
            BookingStatus = bookingStatus;
            Notes = notes;
        }

        private int GetCurentId()
        {
            string sqlRoomBooking = "SELECT * FROM RoomBookings";//lấy danh sách các booking phong
            DataProvider.GetAllRoomBooking(sqlRoomBooking);
            int numOfId = DataProvider.RoomBookings.Count;
            return ++numOfId;
        }
    }
}
