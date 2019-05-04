using System;
using System.ComponentModel.DataAnnotations;

namespace Animation.Models
{
    public class Graph
    {
        [Required(ErrorMessage = "Time is required")]
        public double Time { get; set; }

        [Required(ErrorMessage = "Action is required")]
        public string Commend { get; set; }

        [Required(ErrorMessage = "Object is required")]
        public string Object { get; set; }

        [Required(ErrorMessage = "At least one valid Node Id is required")]
        public string NodeId { get; set; }


        public string NodeIdEdge { get; set; }   
    }
}
