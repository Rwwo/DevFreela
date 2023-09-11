using DevFreela.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection;

namespace DevFreela.Infrastructure.Persistence
{
    public class DevFreelaDbContext : DbContext
    {
        public DevFreelaDbContext(DbContextOptions<DevFreelaDbContext> options) : base(options)
        {
            //Projects = new List<Project>()
            //{
            //    new Project("Meu Projeto ASPNET Core 1", "Minha descrição de Projeto 1", 1, 1, 10000)
            //    ,new Project("Meu Projeto ASPNET Core 2", "Minha descrição de Projeto 2", 1, 1, 20000)
            //    ,new Project("Meu Projeto ASPNET Core 3", "Minha descrição de Projeto 3", 1, 1, 30000)
            //};
            //
            //Users = new List<User>
            //{
            //     new User("Rubens José Facco Filho 1","rubensfacco94@gmail.com 1", new System.DateTime(1994,07,12))
            //    ,new User("Rubens José Facco Filho 2","rubensfacco94@gmail.com 2", new System.DateTime(1994,07,12))
            //    ,new User("Rubens José Facco Filho 3","rubensfacco94@gmail.com 3", new System.DateTime(1994,07,12))
            //};
            //
            //Skills = new List<Skill>()
            //{
            //    new Skill("C#"),
            //    new Skill(".Net Core"),
            //    new Skill("SQL")
            //};

        }
        //public List<Project> Projects { get; set; }
        //public List<User> Users { get; set; }
        //public List<Skill> Skills { get; set; }
        //public List<UserSkill> UserSkills { get; set; }
        //public List<ProjectComment> ProjectComments { get; set; }

        public DbSet<Project> Projects { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<UserSkill> UserSkills { get; set; }
        public DbSet<ProjectComment> ProjectComments { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}
