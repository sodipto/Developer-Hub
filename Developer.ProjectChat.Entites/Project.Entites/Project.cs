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


        public string ProjectName { get; set; }


        public string ProgrammingLanguage { get; set; }


        public string  Status { get; set; }



    }
}
