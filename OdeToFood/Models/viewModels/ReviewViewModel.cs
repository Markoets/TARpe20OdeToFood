using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Models.viewModels
{
    public class ReviewViewModel
    {
            
        public int Id { get; set; }
        public int Rating { get; set; }
        public string Body { get; set; }
    }
}
