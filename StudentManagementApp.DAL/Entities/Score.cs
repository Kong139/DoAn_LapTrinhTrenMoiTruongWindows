namespace StudentManagementApp.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Score")]
    public partial class Score
    {
        public int ScoreID { get; set; }

        [Required]
        [StringLength(10)]
        public string StudentID { get; set; }

        [Required]
        [StringLength(10)]
        public string SubjectID { get; set; }

        [Required]
        [StringLength(2)]
        public string ScoreCategoryID { get; set; }

        public double ScoreValue { get; set; }

        public virtual ScoreCategory ScoreCategory { get; set; }

        public virtual Student Student { get; set; }

        public virtual Subject Subject { get; set; }
    }
}
