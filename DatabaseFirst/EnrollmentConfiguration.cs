// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

namespace DatabaseFirst
{

    // Enrollments
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.19.3.0")]
    public class EnrollmentConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Enrollment>
    {
        public EnrollmentConfiguration()
            : this("dbo")
        {
        }

        public EnrollmentConfiguration(string schema)
        {
            ToTable(schema + ".Enrollments");
            HasKey(x => x.EnrollmentId);

            Property(x => x.EnrollmentId).HasColumnName(@"EnrollmentId").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.StudentStudentId).HasColumnName(@"StudentStudentId").IsRequired().HasColumnType("int");
            Property(x => x.CourseCourseId).HasColumnName(@"CourseCourseId").IsRequired().HasColumnType("int");

            // Foreign keys
            HasRequired(a => a.Course).WithMany(b => b.Enrollments).HasForeignKey(c => c.CourseCourseId); // FK_EnrollmentCourse
            HasRequired(a => a.Student).WithMany(b => b.Enrollments).HasForeignKey(c => c.StudentStudentId); // FK_StudentEnrollment
        }
    }

}
// </auto-generated>