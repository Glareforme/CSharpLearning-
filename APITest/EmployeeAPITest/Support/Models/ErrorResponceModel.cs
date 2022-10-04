namespace APITest.Models
{
    public class ResponceModelError
    {
        public string status { get; set; }

        public string message { get; set; }

        public int code { get; set; }

        public string errors { get; set; }
    }
}
