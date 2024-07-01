using System;

namespace BIBLIOTECA_PROJETO.classes
{
    public class Livro
    {
        public int RegistrationNumber { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Classification { get; set; }
        public string AcquisitionMethod { get; set; }
        public string Publisher { get; set; }
        public string VolumeNumber { get; set; }
        public string Observations { get; set; }
        public string Condition { get; set; }
    }
}
