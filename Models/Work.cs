using Microsoft.VisualBasic;

namespace WebFrontToBack.Models;

public class Work
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string ImagePath { get; set;}
    public DateTime CreatetAt { get; set; }= DateTime.Now;
}
