namespace StudentManagementApp.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Registration")]
    public partial class Registration
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string StudentID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string CourseID { get; set; }

        public DateTime RegistrationDate { get; set; }

        public virtual Course Course { get; set; }

        public virtual Student Student { get; set; }
    }
}
