using System;

namespace EntityLayer.Concrete
{
    public class News
    {
        public int NewsID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }

    }
}
