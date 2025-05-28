using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices.JavaScript;

namespace WebApplication1.Models;


[Table("Patient")]
public class Patient
{
    [Key]
    public int IdPatient { get; set; } 
    
    
    [MaxLength(100)]
    public string firstName { get; set; } 
     
     
    [MaxLength(100)]
    public string lastName { get; set; } 
     
     
    public DateTime BirthDate { get; set; }

    public virtual ICollection<Prescription> Prescriptions { get; set; } = null!;
}