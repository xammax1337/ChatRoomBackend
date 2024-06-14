﻿using Microsoft.AspNetCore.Identity;

namespace Admix.Models
{
    public class ChatMessage
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public IdentityUser User { get; set; }
        public string Message { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
