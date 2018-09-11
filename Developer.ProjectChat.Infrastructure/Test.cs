using DeveloperHub.ProjectChat.Entites.Project.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperHub.ProjectChat.Infrastructure
{
    class Test
    {
        static void Main(string[] args)
        {

            ProjectDeveloper p = new ProjectDeveloper();
            DeveloperHubDbContext db = new DeveloperHubDbContext();

            p.DeveloperId = 1;

            db.ProjectDevelopers.Add(p);
            db.SaveChanges();
            Console.WriteLine("Complete");

            Console.ReadKey();


        }
    }
}
