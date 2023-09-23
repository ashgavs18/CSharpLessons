using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCefApp.Models
{
    public class Appointment
    {
        [Key]
        [Column("Appointmentno")]
        public int Id { get; set; }
        [Required]
        public int PatientId { get; set; }
        [Required]
        public string DoctorId { get; set; }
        [Required]
        public DateTime DateOfAppointment { get; set; }
        [Required]  
        public bool Status { get; set; }
    }
}
