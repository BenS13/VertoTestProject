using System.ComponentModel.DataAnnotations;

namespace VertoTestProject.Models
{
    public class Content
    {
        public int Id { get; set; }
        
        public string? Title { get; set; }
        public string? ImageURL { get; set; }
        
        public string? Description { get; set; }
    }
}
