namespace StudentManagementApp.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Student")]
    public partial class Student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Student()
        {
            Registrations = new HashSet<Registration>();
            Scores = new HashSet<Score>();
        }

        [StringLength(10)]
        public string StudentID { get; set; }

        [Required]
        [StringLength(50)]
        public string StudentName { get; set; }

        public bool Gender { get; set; }

        [Required]
        [StringLength(10)]
        public string Class { get; set; }

        public double GPA { get; set; }

        public int FacultyID { get; set; }

        public int? MajorID { get; set; }

        public DateTime Birthday { get; set; }

        [Required]
        [StringLength(15)]
        public string Phone { get; set; }

        [Required]
        [StringLength(100)]
        public string Address { get; set; }

        public int StatusID { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(255)]
        public string Avatar { get; set; }

        public virtual Faculty Faculty { get; set; }

        public virtual Major Major { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Registration> Registrations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Score> Scores { get; set; }

        public virtual Status Status { get; set; }
    }
}
