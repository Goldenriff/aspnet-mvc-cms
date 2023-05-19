﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMvcCms.Entity.Models
{
    public class Post
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User Users { get; set; }

        public string Title { get; set; }
        public string Content { get; set; } //Tür'ü 'ntext' olarak değiştirilecek!!!
    }
}
