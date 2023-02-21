using System;

namespace lavomaticApp.Dto
{
    public class DtoLaundry
    {
        public long Id { get; set; }
        public string Na { get; set; }
        public decimal La { get; set; }
        public decimal Lo { get; set; }
        public string Ho { get; set; }
        public Nullable<bool> Ch { get; set; }
    }
}