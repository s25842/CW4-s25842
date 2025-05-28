using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models;
[Table("PrescriptionMedicament")]
[PrimaryKey(nameof(IdMedicament),nameof(IdPrescription))]
public class PrescriptionMedicament
{
    public int IdMedicament { get; set; }
    public int IdPrescription { get; set; }
    public int Dose { get; set; }
    [MaxLength(100)]
    public String Details { get; set; }
    [ForeignKey("IdPrescription")]
    public virtual Prescription Prescription { get; set; } = null!;
    [ForeignKey("IdMedicament")]
    public virtual Medicament Medicament { get; set; } = null!;
}