﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Core.Models
{
    class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Version { get; set; }
    }
}