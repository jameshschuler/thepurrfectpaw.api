using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThePurrfectPaw.API.Models.Request
{
    public class PostingsResourceParameters
    {
        public int? ShelterId { get; set; }
        public string SearchQuery { get; set; }
    }
}
