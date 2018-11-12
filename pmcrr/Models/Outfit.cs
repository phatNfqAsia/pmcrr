namespace pmcrr.Models {
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;

    public enum PurposeEnum { casual, work, formal }
    public class Outfit {
        public int id { get; set; }
        public PurposeEnum purpose { get; set; } 
    }
}