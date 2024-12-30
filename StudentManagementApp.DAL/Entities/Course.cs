namespace StudentManagementApp.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Course")]
    public partial class Course
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Course()
        {
            Registrations = new HashSet<Registration>();
        }

        [StringLength(5)]
        public string CourseID { get; set; }

        [Required]
        [StringLength(10)]
        public string SubjectID { get; set; }

        public int TeacherID { get; set; }

        public int SemesterID { get; set; }

        [Required]
        [StringLength(100)]
        public string Schedule { get; set; }

        public int MaxStudents { get; set; }

        public int? CurrentStudents { get; set; }

        public virtual Semester Semester { get; set; }

        public virtual Subject Subject { get; set; }

        public virtual Teacher Teacher { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Registration> Registrations { get; set; }
    }
}
