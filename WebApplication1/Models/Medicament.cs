﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models;
[Table("Medicament")]
public class Medicament
{
    [Key]
    public int IdMedicament { get; set; }
    [MaxLength(100)]
    public String Name { get; set; }
    [MaxLength(100)]
    public String Description { get; set; }
    [MaxLength(100)]
    public String Type { get; set; }
    public virtual ICollection<PrescriptionMedicament> PrescriptionMedicaments { get; set; } 
}