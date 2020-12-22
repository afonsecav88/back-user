using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ListaTareas.Models
{
    public partial class ListaTareasContext : DbContext
    {
        public ListaTareasContext()
        {
        }

        public ListaTareasContext(DbContextOptions<ListaTareasContext> options)
            : base(options)
        {
        }


        //La propiedad Tareas es la que uso para entity framework y asi mismo se llama la tabla
        //EL DBSet Tarea es el nombre de la clase modelo
        public virtual DbSet<Tarea> Tareas { get; set; }

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("DefaultConnection");
            }
        }*/

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tarea>(entity =>
            {
                entity.Property(e => e.Descripción)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength(true);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
