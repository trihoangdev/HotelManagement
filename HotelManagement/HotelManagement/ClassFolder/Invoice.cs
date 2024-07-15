
using System;

namespace HotelManagement.ClassFolder
{
    public class Invoice
    {
        public int InvoiceID { get; set; }
        public int BookingID { get; set; }
        public DateTime InvoiceDate { get; set; }
        public double TotalAmount { get; set; }
        public double PaidAmount { get; set; }
        public string PaymentStatus { get; set; }
        public string Notes { get; set; }
        public Invoice() { }
        public Invoice(int invoiceID, int bookingID, DateTime invoiceDate, double totalAmount,
            double paidAmount, string paymentStatus, string notes)
        {
            InvoiceID = invoiceID;
            BookingID = bookingID;
            InvoiceDate = invoiceDate;
            TotalAmount = totalAmount;
            PaidAmount = paidAmount;
            PaymentStatus = paymentStatus;
            Notes = notes;
        }
        public Invoice( int bookingID, DateTime invoiceDate, double totalAmount,
            double paidAmount, string paymentStatus, string notes)
        {
            InvoiceID = GetInvoiceId();
            BookingID = bookingID;
            InvoiceDate = invoiceDate;
            TotalAmount = totalAmount;
            PaidAmount = paidAmount;
            PaymentStatus = paymentStatus;
            Notes = notes;
        }

        private int GetInvoiceId()
        {
            DataProvider.GetAllInvoice();
            int currId = DataProvider.Invoices.Count;
            return currId + 1;
        }
    }
}
