using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer.ProjectChat.Entites.Post.Entites
{
    public class ProjectChat
    {
        public int ProjectChatId { get; set; }

        //foreignkey
        public int ProjectId { get; set; }

        //foreignkey
        public int DeveloperId { get; set; }

        public string Comment { get; set; }

        public string FileUrl { get; set; }

        public string ImageUrl { get; set; }





    }
}
