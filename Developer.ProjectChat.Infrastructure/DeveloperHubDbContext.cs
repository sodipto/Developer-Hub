
using DeveloperHub.ProjectChat.Entites.Developers.Entites;
using DeveloperHub.ProjectChat.Entites.Project.Entites;
using DeveloperHub.ProjectChat.Entites.Post.Entites;

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperHub.ProjectChat.Infrastructure
{
    public class DeveloperHubDbContext:DbContext
    {
        public DbSet<Developer> Developers { get; set; }

        public DbSet<ProjectDiscuss> ProjectDiscusses { get; set; }

        public DbSet<Project>Projects { get; set; }

        public DbSet<ProjectDeveloper> ProjectDevelopers { get; set; }


    }
}
