namespace pmcrr.Models {
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    public class User {
        public int id {get; set;}
        [Required]
        public string name {get; set;}
        public string email {get; set;}
    }
}