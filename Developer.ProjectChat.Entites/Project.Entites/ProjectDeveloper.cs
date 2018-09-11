using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer.ProjectChat.Entites.Project.Entites
{
    public class ProjectDeveloper
    {
        [Key]
        public int Id { get; set; }

        public int DeveloperId { get; set; }


    }
}
