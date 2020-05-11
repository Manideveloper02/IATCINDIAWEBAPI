using Microsoft.EntityFrameworkCore;

namespace IATCINDIAWEBAPI.Models
{
    public partial class IatcindiaContext : DbContext
    {
        public IatcindiaContext()
        {
        }

        public IatcindiaContext(DbContextOptions<IatcindiaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<IatcMAwards> IatcMAwards { get; set; }
        public virtual DbSet<IatcMEvent> IatcMEvent { get; set; }
        public virtual DbSet<IatcMGallery> IatcMGallery { get; set; }
        public virtual DbSet<IatcMResource> IatcMResource { get; set; }
        public virtual DbSet<IatcMUser> IatcMUser { get; set; }
        public virtual DbSet<IatcindiaMMemberdetails> IatcindiaMMemberdetails { get; set; }
        public virtual DbSet<IatcindiaMScientificAbstractSubmission> IatcindiaMScientificAbstractSubmission { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=43.255.152.25;Initial Catalog=IATC_INDIA;User ID=IATC_INDIA;Password=IATC_INDIA@03;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:DefaultSchema", "IATC_INDIA");

            modelBuilder.Entity<Department>(entity =>
            {
                entity.Property(e => e.DepartmentId)
                    .HasColumnName("DepartmentID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<IatcMAwards>(entity =>
            {
                entity.HasKey(e => e.PkId)
                    .HasName("PK__IATC_M_A__8BEC115EAF4868C5");

                entity.ToTable("IATC_M_Awards");

                entity.Property(e => e.PkId).HasColumnName("Pk_id");

                entity.Property(e => e.AwardsBanner)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.AwardsDate)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AwardsDetails)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.AwardsId)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AwardsLocation)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AwardsTitle)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Lastmodified).HasColumnType("datetime");

                entity.Property(e => e.StatusFlag)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<IatcMEvent>(entity =>
            {
                entity.HasKey(e => e.PkId)
                    .HasName("PK__IATC_M_E__8BEC115E677C4484");

                entity.ToTable("IATC_M_Event");

                entity.Property(e => e.PkId).HasColumnName("Pk_id");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EventBanner)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EventDate)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EventDetails)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.EventId)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EventLocation)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EventState)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EventTitle)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Lastmodified).HasColumnType("datetime");

                entity.Property(e => e.StatusFlag)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<IatcMGallery>(entity =>
            {
                entity.HasKey(e => e.PkId)
                    .HasName("PK__IATC_M_G__8BEC115E1EB532F8");

                entity.ToTable("IATC_M_Gallery");

                entity.Property(e => e.PkId).HasColumnName("Pk_id");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EventId)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Image).IsUnicode(false);

                entity.Property(e => e.Lastmodified).HasColumnType("datetime");

                entity.Property(e => e.StatusFlag)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<IatcMResource>(entity =>
            {
                entity.HasKey(e => e.PkId)
                    .HasName("PK__IATC_M_R__8BEC115E38D0B89A");

                entity.ToTable("IATC_M_Resource");

                entity.Property(e => e.PkId).HasColumnName("Pk_id");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Lastmodified).HasColumnType("datetime");

                entity.Property(e => e.ResourceFileName).IsUnicode(false);

                entity.Property(e => e.ResourceId)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StatusFlag)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<IatcMUser>(entity =>
            {
                entity.HasKey(e => e.PkId)
                    .HasName("PK__IATC_M_U__8BEF1566270A2A39");

                entity.ToTable("IATC_M_User");

                entity.Property(e => e.PkId).HasColumnName("Pk_Id");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmailId)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FirstLoginStatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.LastLogin).HasColumnType("datetime");

                entity.Property(e => e.Lastmodified).HasColumnType("datetime");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Role)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('B')");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<IatcindiaMMemberdetails>(entity =>
            {
                entity.HasKey(e => e.PkId)
                    .HasName("PK__iatcindi__8BEC115ED51BC714");

                entity.ToTable("iatcindia_m_memberdetails");

                entity.Property(e => e.PkId).HasColumnName("Pk_id");

                entity.Property(e => e.Bank)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CityInstitution)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNo1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNo2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Crtdate)
                    .HasColumnName("crtdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateofBirth)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DateofTransaction)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Designation)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EducationQualification)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Emailid)
                    .HasColumnName("EMAILID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Iatcregno)
                    .HasColumnName("IATCREGNO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Medicine)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NottoregistrationNo)
                    .HasColumnName("NOTTORegistrationNo")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nursing)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentMode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Photo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PostGraduate)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.QualificationDetails)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Salutations)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StateInstitution)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TransacationNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.YearofExperience)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<IatcindiaMScientificAbstractSubmission>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("iatcindia_m_scientificAbstractSubmission");

                entity.Property(e => e.Abstract).IsUnicode(false);

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Affiliationcoauthor1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Affiliationcoauthor2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Affiliationofthepresentingauthor)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Category)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Coauthor1)
                    .HasColumnName("coauthor1")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Coauthor2)
                    .HasColumnName("coauthor2")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Contact)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Contactno)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Crtdate)
                    .HasColumnName("crtdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Designation)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Institution)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Pincode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PkId)
                    .HasColumnName("pk_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Preferredpresentation)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Presentingauthor)
                    .HasColumnName("presentingauthor")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });


            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
