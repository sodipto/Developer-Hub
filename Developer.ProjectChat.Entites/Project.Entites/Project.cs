using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer.ProjectChat.Entites.Project.Entites
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }

        [Required]
        public string ProjectName { get; set; }

        [Required]
        public string ProgrammingLanguage { get; set; }

        [Required]
        public string  Status { get; set; }



    }
}
