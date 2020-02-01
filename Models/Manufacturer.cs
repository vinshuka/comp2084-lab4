using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PhoneApplication.Models
{
    public class Manufacturer
    {
        public Manufacturer()
        {
            ManufacturerName = "";
            URL = "";
            Founded = new DateTime(1960, 1, 1);
        }

        [Key]
        public int ManufacturerID { get; set; }
        public string ManufacturerName { get; set; }
        public string URL { get; set; }
        public DateTime Founded { get; set; }
        public List<Phone> PhoneList { get; set; }
    }
}