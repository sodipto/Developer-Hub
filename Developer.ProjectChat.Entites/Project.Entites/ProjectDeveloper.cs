﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperHub.ProjectChat.Entites.Project.Entites
{
    public class ProjectDeveloper
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int DeveloperId { get; set; }


        [Required]
        public int ProjectId { get; set; }




    }
}
