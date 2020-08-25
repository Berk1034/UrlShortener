using Newtonsoft.Json;
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

        [Display(Name = "Full Link"), RegularExpression(@"^(?:http(s)?:\/\/)?[\w.-]+(?:\.[\w\.-]+)+[\w\-\._~:/?#[\]@!\$&'\?%\(\)\*\+,;=.]+$"), Required]
        public string FullName { get; set; }

        [Display(Name = "Shortened Link")]
        public string ShortName { get; set; }

        [Display(Name = "Creation Date"), DataType(DataType.Date)]
        public DateTime CreationDate { get; set; } = DateTime.Now.Date;

        [Display(Name = "Redirects Count")]
        public int Counter { get; set; } = 0;
    }
}
