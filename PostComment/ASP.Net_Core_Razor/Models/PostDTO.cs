﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.Net_Core_Razor.Models
{
    public class PostDTO
    {
        public int PostId { get; set; }

        public string Description { get; set; }

        public string Domain { get; set; }

        public System.DateTime Date { get; set; }
        public virtual ICollection<CommentDTO> Comments { get; set; }

        public PostDTO()
        {
            Comments = new List<CommentDTO>();
        }
    }
}