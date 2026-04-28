using System;

namespace RentingSystem.Models
{
    public class Message
    {
        public int MessageID { get; set; }
        public int SenderID { get; set; }
        public int ReceiverID { get; set; }
        public int PropertyID { get; set; }
        public string MessageText { get; set; }
        public DateTime SentDate { get; set; }
        public bool IsRead { get; set; }
    }
}