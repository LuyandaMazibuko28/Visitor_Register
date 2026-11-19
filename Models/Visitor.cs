using System.ComponentModel.DataAnnotations;

namespace VisitorRegister.Models
{
    public class Visitor
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required.")]
        public required string Name { get; set; }
        [Required(ErrorMessage = "Surname is required.")]
        public required string Surname { get; set; }
        public DateTime VisitDateTime { get; set; }
        [Required(ErrorMessage = "Phone number  is required.")]
        public required string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Reason for visit is required.")]
        public required string ReasonForVisit { get; set; }
        [Required(ErrorMessage = "Signature is required.")]
        [MinLength(1, ErrorMessage = "Signature is required.")]
        public required byte[] Signature { get; set; }
    }
}