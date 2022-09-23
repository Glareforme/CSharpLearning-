using System;
using System.Collections.Generic;
using System.Text;

namespace APITest.Models
{
    public class ErrorResponceModel
    {
        public string status { get; set; }
        public string message { get; set; }
        public int code { get; set; }
        public string errors { get; set; }
    }
}
