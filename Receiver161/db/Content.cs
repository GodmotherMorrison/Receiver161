﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receiver161
{
    [Table("Contents")]
    public class Content
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
    }
}
