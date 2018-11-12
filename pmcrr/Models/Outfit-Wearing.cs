namespace pmcrr.Models {
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;

    public class OutfitAndWearing {
        public int id { get; set; }
        [ForeignKey("Outfit")]
        public int outfitId { get; set; }
        public Outfit outfit { get; set; }
        [ForeignKey("Wearing")]
        public int wearingId { get; set; }
        public Wearing wearing { get; set; }  
    }

}