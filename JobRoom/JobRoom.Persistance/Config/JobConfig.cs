using JobRoom.Domain.Job;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobRoom.Persistance.Config
{
    public class JobConfig : IEntityTypeConfiguration<Job>
    {
        public void Configure(EntityTypeBuilder<Job> builder)
        {
           
                builder.ToTable("Job", "Job");

                builder.HasIndex(e => e.CategoryId, "IX_JobCategory");

                builder.HasIndex(e => e.Salary, "IX_JobSalary");

                builder.HasIndex(e => e.LocationStateId, "IX_JobState");

                builder.HasIndex(e => e.Title, "IX_JobTtile");

                builder.HasIndex(e => e.Type, "IX_JobType");

                builder.Property(e => e.Id).HasColumnName("ID");

                builder.Property(e => e.CategoryId).HasColumnName("CategoryID");

                builder.Property(e => e.CompanyId).HasColumnName("CompanyID");

                builder.Property(e => e.ConfirmDateTime).HasColumnType("datetime");

                builder.Property(e => e.CreationDateTime).HasColumnType("datetime");

                builder.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(4000);

                builder.Property(e => e.LocationCityId).HasColumnName("LocationCityID");

                builder.Property(e => e.LocationStateId).HasColumnName("LocationStateID");

                builder.Property(e => e.Slug)
                    .IsRequired()
                    .HasMaxLength(450);

                builder.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(250);

                builder.HasOne(d => d.Category)
                    .WithMany(p => p.Jobs)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Job_JobCategory");
           


        }
    }
}
