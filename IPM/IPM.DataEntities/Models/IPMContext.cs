using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace IPM.DataEntities.Models
{
    public partial class IPMContext : DbContext
    {
        public virtual DbSet<AnswerQuestions> AnswerQuestions { get; set; }
        public virtual DbSet<CandidateCertificates> CandidateCertificates { get; set; }
        public virtual DbSet<Candidates> Candidates { get; set; }
        public virtual DbSet<CandidateSkills> CandidateSkills { get; set; }
        public virtual DbSet<CatalogQuestions> CatalogQuestions { get; set; }
        public virtual DbSet<Catalogs> Catalogs { get; set; }
        public virtual DbSet<Certificates> Certificates { get; set; }
        public virtual DbSet<Documents> Documents { get; set; }
        public virtual DbSet<GuidelineCatalogs> GuidelineCatalogs { get; set; }
        public virtual DbSet<Guidelines> Guidelines { get; set; }
        public virtual DbSet<InterviewAnswers> InterviewAnswers { get; set; }
        public virtual DbSet<InterviewProcesses> InterviewProcesses { get; set; }
        public virtual DbSet<InterviewRounds> InterviewRounds { get; set; }
        public virtual DbSet<Interviews> Interviews { get; set; }
        public virtual DbSet<MeetingRequests> MeetingRequests { get; set; }
        public virtual DbSet<MigrationHistory> MigrationHistory { get; set; }
        public virtual DbSet<Positions> Positions { get; set; }
        public virtual DbSet<Questions> Questions { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Rooms> Rooms { get; set; }
        public virtual DbSet<RoundProcesses> RoundProcesses { get; set; }
        public virtual DbSet<Skills> Skills { get; set; }
        public virtual DbSet<SystemParameters> SystemParameters { get; set; }
        public virtual DbSet<UserRoles> UserRoles { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Server=.;Database=IPM;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AnswerQuestions>(entity =>
            {
                entity.HasIndex(e => e.InterviewAnswerId)
                    .HasName("IX_InterviewAnswerID");

                entity.HasIndex(e => e.QuestionId)
                    .HasName("IX_QuestionID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InterviewAnswerId).HasColumnName("InterviewAnswerID");

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.HasOne(d => d.InterviewAnswer)
                    .WithMany(p => p.AnswerQuestions)
                    .HasForeignKey(d => d.InterviewAnswerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.AnswerQuestions_dbo.InterviewAnswers_InterviewResultID");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.AnswerQuestions)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.AnswerQuestions_dbo.Questions_QuestionID");
            });

            modelBuilder.Entity<CandidateCertificates>(entity =>
            {
                entity.HasKey(e => new { e.CandidateId, e.CertificateId });

                entity.HasIndex(e => e.CandidateId)
                    .HasName("IX_CandidateID");

                entity.HasIndex(e => e.CertificateId)
                    .HasName("IX_CertificateID");

                entity.Property(e => e.CandidateId).HasColumnName("CandidateID");

                entity.Property(e => e.CertificateId).HasColumnName("CertificateID");

                entity.HasOne(d => d.Candidate)
                    .WithMany(p => p.CandidateCertificates)
                    .HasForeignKey(d => d.CandidateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.CandidateCertificates_dbo.Candidates_CandidateID");

                entity.HasOne(d => d.Certificate)
                    .WithMany(p => p.CandidateCertificates)
                    .HasForeignKey(d => d.CertificateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.CandidateCertificates_dbo.Certificates_CertificateID");
            });

            modelBuilder.Entity<Candidates>(entity =>
            {
                entity.HasIndex(e => e.InterviewAdminId)
                    .HasName("IX_InterviewAdminID");

                entity.HasIndex(e => e.PositionId)
                    .HasName("IX_PositionID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Birthdate).HasColumnType("datetime");

                entity.Property(e => e.Gpa).HasColumnName("GPA");

                entity.Property(e => e.Idcard).HasColumnName("IDCard");

                entity.Property(e => e.InterviewAdminId).HasColumnName("InterviewAdminID");

                entity.Property(e => e.PositionId).HasColumnName("PositionID");

                entity.HasOne(d => d.InterviewAdmin)
                    .WithMany(p => p.Candidates)
                    .HasForeignKey(d => d.InterviewAdminId)
                    .HasConstraintName("FK_dbo.Candidates_dbo.Users_InterviewAdminID");

                entity.HasOne(d => d.Position)
                    .WithMany(p => p.Candidates)
                    .HasForeignKey(d => d.PositionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Candidates_dbo.Positions_PositionID");
            });

            modelBuilder.Entity<CandidateSkills>(entity =>
            {
                entity.HasKey(e => new { e.CandidateId, e.SkillId });

                entity.HasIndex(e => e.CandidateId)
                    .HasName("IX_CandidateID");

                entity.HasIndex(e => e.SkillId)
                    .HasName("IX_SkillID");

                entity.Property(e => e.CandidateId).HasColumnName("CandidateID");

                entity.Property(e => e.SkillId).HasColumnName("SkillID");

                entity.HasOne(d => d.Candidate)
                    .WithMany(p => p.CandidateSkills)
                    .HasForeignKey(d => d.CandidateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.CandidateSkills_dbo.Candidates_CandidateID");

                entity.HasOne(d => d.Skill)
                    .WithMany(p => p.CandidateSkills)
                    .HasForeignKey(d => d.SkillId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.CandidateSkills_dbo.Skills_SkillID");
            });

            modelBuilder.Entity<CatalogQuestions>(entity =>
            {
                entity.HasIndex(e => e.CatalogId)
                    .HasName("IX_CatalogID");

                entity.HasIndex(e => e.QuestionId)
                    .HasName("IX_QuestionID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.HasOne(d => d.Catalog)
                    .WithMany(p => p.CatalogQuestions)
                    .HasForeignKey(d => d.CatalogId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.CatalogQuestions_dbo.Catalogs_CatalogID");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.CatalogQuestions)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.CatalogQuestions_dbo.Questions_QuestionID");
            });

            modelBuilder.Entity<Catalogs>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<Certificates>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<Documents>(entity =>
            {
                entity.HasIndex(e => e.CandidateId)
                    .HasName("IX_CandidateID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CandidateId).HasColumnName("CandidateID");

                entity.HasOne(d => d.Candidate)
                    .WithMany(p => p.Documents)
                    .HasForeignKey(d => d.CandidateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Documents_dbo.Candidates_CandidateID");
            });

            modelBuilder.Entity<GuidelineCatalogs>(entity =>
            {
                entity.HasIndex(e => e.CatalogId)
                    .HasName("IX_CatalogID");

                entity.HasIndex(e => e.GuidelineId)
                    .HasName("IX_GuidelineID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.GuidelineId).HasColumnName("GuidelineID");

                entity.HasOne(d => d.Catalog)
                    .WithMany(p => p.GuidelineCatalogs)
                    .HasForeignKey(d => d.CatalogId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.GuidelineCatalogs_dbo.Catalogs_CatalogID");

                entity.HasOne(d => d.Guideline)
                    .WithMany(p => p.GuidelineCatalogs)
                    .HasForeignKey(d => d.GuidelineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.GuidelineCatalogs_dbo.Guidelines_GuidelineID");
            });

            modelBuilder.Entity<Guidelines>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<InterviewAnswers>(entity =>
            {
                entity.HasIndex(e => e.CatalogId)
                    .HasName("IX_CatalogID");

                entity.HasIndex(e => e.InterviewId)
                    .HasName("IX_InterviewID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.InterviewId).HasColumnName("InterviewID");

                entity.HasOne(d => d.Catalog)
                    .WithMany(p => p.InterviewAnswers)
                    .HasForeignKey(d => d.CatalogId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.InterviewAnswers_dbo.Catalogs_CatalogID");

                entity.HasOne(d => d.Interview)
                    .WithMany(p => p.InterviewAnswers)
                    .HasForeignKey(d => d.InterviewId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.InterviewAnswers_dbo.Interviews_InterviewID");
            });

            modelBuilder.Entity<InterviewProcesses>(entity =>
            {
                entity.HasIndex(e => e.PositionId)
                    .HasName("IX_PositionID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PositionId).HasColumnName("PositionID");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.Position)
                    .WithMany(p => p.InterviewProcesses)
                    .HasForeignKey(d => d.PositionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.InterviewProcesses_dbo.Positions_PositionID");
            });

            modelBuilder.Entity<InterviewRounds>(entity =>
            {
                entity.HasIndex(e => e.GuidelineId)
                    .HasName("IX_GuidelineID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.GuidelineId).HasColumnName("GuidelineID");

                entity.HasOne(d => d.Guideline)
                    .WithMany(p => p.InterviewRounds)
                    .HasForeignKey(d => d.GuidelineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.InterviewRounds_dbo.Guidelines_GuidelineID");
            });

            modelBuilder.Entity<Interviews>(entity =>
            {
                entity.HasIndex(e => e.CandidateId)
                    .HasName("IX_CandidateID");

                entity.HasIndex(e => e.InterviewAdminId)
                    .HasName("IX_InterviewAdminID");

                entity.HasIndex(e => e.InterviewerId)
                    .HasName("IX_InterviewerID");

                entity.HasIndex(e => e.RoundProcessId)
                    .HasName("IX_RoundProcessID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CandidateId).HasColumnName("CandidateID");

                entity.Property(e => e.InterviewAdminId).HasColumnName("InterviewAdminID");

                entity.Property(e => e.InterviewerId).HasColumnName("InterviewerID");

                entity.Property(e => e.RoundProcessId).HasColumnName("RoundProcessID");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.HasOne(d => d.Candidate)
                    .WithMany(p => p.Interviews)
                    .HasForeignKey(d => d.CandidateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Interviews_dbo.Candidates_CandidateID");

                entity.HasOne(d => d.InterviewAdmin)
                    .WithMany(p => p.InterviewsInterviewAdmin)
                    .HasForeignKey(d => d.InterviewAdminId)
                    .HasConstraintName("FK_dbo.Interviews_dbo.Users_InterviewAdminID");

                entity.HasOne(d => d.Interviewer)
                    .WithMany(p => p.InterviewsInterviewer)
                    .HasForeignKey(d => d.InterviewerId)
                    .HasConstraintName("FK_dbo.Interviews_dbo.Users_InterviewerID");

                entity.HasOne(d => d.RoundProcess)
                    .WithMany(p => p.Interviews)
                    .HasForeignKey(d => d.RoundProcessId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Interviews_dbo.RoundProcesses_RoundProcessID");
            });

            modelBuilder.Entity<MeetingRequests>(entity =>
            {
                entity.HasIndex(e => e.RoomId)
                    .HasName("IX_RoomID");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_User_ID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AppointmentId).HasColumnName("AppointmentID");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.InterviewAdmin).IsRequired();

                entity.Property(e => e.InterviewerEmail).IsRequired();

                entity.Property(e => e.RoomId).HasColumnName("RoomID");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Subject).IsRequired();

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.MeetingRequests)
                    .HasForeignKey(d => d.RoomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.MeetingRequests_dbo.Rooms_RoomID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.MeetingRequests)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.MeetingRequests_dbo.Users_User_ID");
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey });

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<Positions>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<Questions>(entity =>
            {
                entity.HasIndex(e => e.SkillId)
                    .HasName("IX_SkillID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.SkillId).HasColumnName("SkillID");

                entity.HasOne(d => d.Skill)
                    .WithMany(p => p.Questions)
                    .HasForeignKey(d => d.SkillId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Questions_dbo.Skills_SkillID");
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<Rooms>(entity =>
            {
                entity.HasKey(e => e.RoomId);

                entity.Property(e => e.RoomId).HasColumnName("RoomID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<RoundProcesses>(entity =>
            {
                entity.HasIndex(e => e.InterviewProcessId)
                    .HasName("IX_InterviewProcessID");

                entity.HasIndex(e => e.InterviewRoundId)
                    .HasName("IX_InterviewRoundID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InterviewProcessId).HasColumnName("InterviewProcessID");

                entity.Property(e => e.InterviewRoundId).HasColumnName("InterviewRoundID");

                entity.Property(e => e.RoundOrder).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.InterviewProcess)
                    .WithMany(p => p.RoundProcesses)
                    .HasForeignKey(d => d.InterviewProcessId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.RoundProcesses_dbo.InterviewProcesses_InterviewProcessID");

                entity.HasOne(d => d.InterviewRound)
                    .WithMany(p => p.RoundProcesses)
                    .HasForeignKey(d => d.InterviewRoundId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.RoundProcesses_dbo.InterviewRounds_InterviewRoundID");
            });

            modelBuilder.Entity<Skills>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<SystemParameters>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<UserRoles>(entity =>
            {
                entity.HasKey(e => new { e.Account, e.RoleId });

                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_RoleID");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_User_ID");

                entity.Property(e => e.Account).HasMaxLength(128);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.UserRoles_dbo.Roles_RoleID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.UserRoles_dbo.Users_User_ID");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");
            });
        }
    }
}
