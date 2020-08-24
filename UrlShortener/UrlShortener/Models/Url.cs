using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UrlShortener.Models
{
    public class Url
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string ShortName { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreationDate { get; set; }
        
        public int Counter { get; set; }
    }
}
