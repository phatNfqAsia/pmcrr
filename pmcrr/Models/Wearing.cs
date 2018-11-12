namespace pmcrr.Models {
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;

    public enum CategoryEnum { sneaker, tshirt, trouser } 
    public class Wearing {
        public int id { get; set; }
        public CategoryEnum category { get; set; }
        [ForeignKey("User")]
        public int ownerId { get; set; }
        public User owner { get; set; }
    }

}