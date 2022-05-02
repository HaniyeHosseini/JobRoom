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
    public class JobCategoryConfig : IEntityTypeConfiguration<JobCategory>
    {
        public void Configure(EntityTypeBuilder<JobCategory> modelBuilder)
        {

            modelBuilder.ToTable("JobCategory");

            modelBuilder.Property(e => e.Id).HasColumnName("ID");

            modelBuilder.Property(e => e.Description).HasMaxLength(550);

            modelBuilder.Property(e => e.ParentId).HasColumnName("ParentID");

            modelBuilder.Property(e => e.Picture)
                    .IsRequired()
                    .HasMaxLength(4000);

                modelBuilder.Property(e => e.PictureAlt)
                    .IsRequired()
                    .HasMaxLength(150);

                modelBuilder.Property(e => e.PictureTitle)
                    .IsRequired()
                    .HasMaxLength(150);

                modelBuilder.Property(e => e.Slug)
                    .IsRequired()
                    .HasMaxLength(450);

                modelBuilder.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100);

                modelBuilder.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("ParentFK");
            
        }
    }
}
