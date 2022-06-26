using System.ComponentModel.DataAnnotations.Schema;

namespace blogApp.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }  
        public string Topic { get; set; }
        public string? image { get; set; }   

        public DateTime CreatedDate { get; set; }

        [ForeignKey("Section")]
        public int SectionId { get; set; }
        public Section Section { get; set; }
    }
}
