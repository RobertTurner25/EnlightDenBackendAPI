﻿using EnlightDenBackendAPI.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

public class ClassConfig : IEntityTypeConfiguration<Class>
{
    public void Configure(EntityTypeBuilder<Class> builder)
    {
        builder.ToTable("Classes", "General"); 
        builder.HasKey(c => c.Id); 

        builder.HasOne(c => c.User)
            .WithMany() 
            .HasForeignKey(c => c.UserId)
            .OnDelete(DeleteBehavior.Cascade); 

    }
}
