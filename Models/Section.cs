using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace blogApp.Models
{
    public class Section 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? info { get; set; }   
        public List<Section> Sections { get; set; }
        public List<Blog> Blogs { get; set; }
        [ForeignKey("Section")]
        public int? SectionId { get; set; }
        public Section section { get; set; }
    }
}
