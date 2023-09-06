using DevFreela.Core.Entities;
using System.Collections.Generic;

namespace DevFreela.Infrastructure.Persistence
{
    public class DevFreelaDbContext
    {
        public DevFreelaDbContext()
        {
            Projects = new List<Project>()
            {
                new Project("Meu Projeto ASPNET Core 1", "Minha descrição de Projeto 1", 1, 1, 10000)
                ,new Project("Meu Projeto ASPNET Core 2", "Minha descrição de Projeto 2", 1, 1, 20000)
                ,new Project("Meu Projeto ASPNET Core 3", "Minha descrição de Projeto 3", 1, 1, 30000)
            };

            Users = new List<User>
            {
                 new User("Rubens José Facco Filho 1","rubensfacco94@gmail.com 1", new System.DateTime(1994,07,12))
                ,new User("Rubens José Facco Filho 2","rubensfacco94@gmail.com 2", new System.DateTime(1994,07,12))
                ,new User("Rubens José Facco Filho 3","rubensfacco94@gmail.com 3", new System.DateTime(1994,07,12))
            };

            Skills = new List<Skill>()
            {
                new Skill("C#"),
                new Skill(".Net Core"),
                new Skill("SQL")
            };

        }
        public List<Project> Projects { get; set; }
        public List<User> Users { get; set; }
        public List<Skill> Skills { get; set; }
    }
}
