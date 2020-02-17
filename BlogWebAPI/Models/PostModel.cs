using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogWebAPI.Models
{
    public class PostModel
    {
        public int Id { get; set; }

        public string Tittle { get; set; }

        public string Content { get; set; }

        public int UserId { get; set; }

        public DateTime Date { get; set; }
    }
}
