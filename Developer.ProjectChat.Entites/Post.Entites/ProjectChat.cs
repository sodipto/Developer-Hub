using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer.ProjectChat.Entites.Post.Entites
{
    public class ProjectChat
    {
        [Key]
        public int ProjectChatId { get; set; }

        //foreignkey
        [Required]
        public int ProjectId { get; set; }

        //foreignkey
        [Required]
        public int DeveloperId { get; set; }

        [Required]
        public string Comment { get; set; }

        public string FileUrl { get; set; }

        public string ImageUrl { get; set; }





    }
}
