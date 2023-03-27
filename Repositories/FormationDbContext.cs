using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class FormationDbContext : DbContext
    {
     
        public FormationDbContext(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<RestaurantModel> Restaurants { get; set;}
        public virtual DbSet<CuisineModel> Cuisines { get; set; }


        /// <summary>
        /// On configure les tables des models à ce niveau en donnant en suivant ce exemple
        /// </summary>
        /// <param name="modelBuilder"></param>
    //    protected override void OnModelCreating(ModelBuilder modelBuilder)
    //    {
    //        modelBuilder.Entity<RestaurantModel>(entity =>
    //        {
    //            ///Pour mettre la clé primaire 
    //            entity.HasKey(e => e.Id)
    //            .HasName("PK_Restaurant");


    //            ///Pour mettre les propriété d'un attribut donné
    //            entity.Property(e => e.Name)
    //            .HasColumnName("Name")
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .IsRequired(true);


    //            //Ajout de le clé secondaire dans la table
    //            //entity.HasMany(e => e.Cuisines)
    //            //.WithOne(r => r.Restaurant)
    //            //.HasForeignKey(p => p.RestaurantId)
    //            //.HasConstraintName("FK_Cuisins_RestaurantId");


    //            entity.Property(e => e.Description)
    //            .HasMaxLength(200);


    //        });


    //        modelBuilder.Entity<CuisineModel>(entity =>
    //        {
    //            entity.HasKey(e => new { e.Id })
    //            .HasName("PK_Cuisin"); 
                
    //            entity.Property(e => e.Id)
    //            .HasColumnName("id")
    //            .ValueGeneratedOnAdd(); 

    //            // Auto-increment               
    //            //entity.HasOne(e => e.Restaurant)                 
    //            //.WithMany(r => r.Cuisines)                 
    //            //.HasForeignKey(p => p.RestaurantId)                
    //            //.HasConstraintName("FK_Cuisins_RestaurantId");

    //        });
    //    }
    }
}
