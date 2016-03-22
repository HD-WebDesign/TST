using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TST.DAL
{
    public class Metadata
    {
    }

    public class EmployeesMetaData
    {
        [Display(Name = "First Name")]//Used by LabelFor()
        [StringLength(50, ErrorMessage = "First must be of 50 characters or less")]
        [Required(ErrorMessage = "* Required")]
        public string EmployeeFirstName { get; set; }

        [Display(Name = "Last Name")]//Used by LabelFor()
        [StringLength(50, ErrorMessage = "Last must be of 50 characters or less")]
        [Required(ErrorMessage = "* Required")]
        public string EmployeeLastName { get; set; }

        [Display(Name = "Department")]//Used by LabelFor()
        [Required(ErrorMessage = "* Required")]
        public int DepartmentID { get; set; }

        [Display(Name = "Status")]//Used by LabelFor()
        [Required(ErrorMessage = "* Required")]
        public int StatusID { get; set; }

        [Display(Name = "Adress 1")]//Used by LabelFor()
        [StringLength(100, ErrorMessage = "Address 1 must be of 100 characters or less")]
        [Required(ErrorMessage = "* Required")]
        public string AddressOne { get; set; }

        [Display(Name = "Adress 2")]//Used by LabelFor()
        [StringLength(100, ErrorMessage = "Address 2 must be of 100 characters or less")]

        public string AddressTwo { get; set; }

        [Display(Name = "City")]//Used by LabelFor()
        [StringLength(50, ErrorMessage = "City must be of 50 characters or less")]
        [Required(ErrorMessage = "* Required")]
        public string City { get; set; }

        [Display(Name = "State")]//Used by LabelFor()
        [StringLength(2, ErrorMessage = "State must be 2 character abreviation")]
        [Required(ErrorMessage = "* Required")]
        public string State { get; set; }

        [Display(Name = "Zipcode")]//Used by LabelFor()
        [StringLength(5, ErrorMessage = "Zipcode must be 5 digits")]
        [Required(ErrorMessage = "* Required")]
        public string Zipcode { get; set; }

        [Display(Name = "Zipcode")]//Used by LabelFor()
        [StringLength(4, ErrorMessage = "Zipcode must be 4 digits")]
  
        public string ZipcodePlusFour { get; set; }

        [Display(Name = "Picture")]
        public string ProfileImage { get; set; }


        public string UserID { get; set; }

        [Display(Name = "Date of Birth")]//Used by LabelFor()
        [Required(ErrorMessage = "* Required")]
        public System.DateTime DateOfBirth { get; set; }

        [Display(Name = "Date of Hire")]//Used by LabelFor()
        [Required(ErrorMessage = "* Required")]
        public System.DateTime DateOfHire { get; set; }

        [Display(Name = "Home Phone Number")]//Used by LabelFor()
        [StringLength(10, ErrorMessage = "Phone number must be 10 digits without any punctuation")]
        public string HomePhoneNumber { get; set; }

        [Display(Name = "Home Phone Number")]//Used by LabelFor()
        [StringLength(10, ErrorMessage = "Phone number must be 10 digits without any punctuation")]
        [Required(ErrorMessage = "* Required")]
        public string CellPhoneNumber { get; set; }

        [Display(Name = "Date Of Separation")]//Used by LabelFor()
        public Nullable<System.DateTime> DateOfSeparation { get; set; }

        [Display(Name = "State")]//Used by LabelFor()
        [StringLength(150, ErrorMessage = "Email must be of 150 characters or less")]
        [Required(ErrorMessage = "* Required")]
        public string Email { get; set; }


        public string Notes { get; set; }
    }
    [MetadataType(typeof(EmployeesMetaData))]


    public partial class TSTEmployee { }

    public class DepartmentMetaData
    {

        [Display(Name = "Department Names")]//Used by LabelFor()
        [StringLength(25, ErrorMessage = "Name must be of 25 characters or less")]
        [Required(ErrorMessage = "* Required")]
        public string DepartmentName { get; set; }

        [Display(Name = "Description")]//Used by LabelFor()
        [StringLength(140, ErrorMessage = "Description must be of 140 characters or less")]
        [Required(ErrorMessage = "* Required")]
        public string DepartmentDescription { get; set; }


        [Display(Name = "Active?")]//Used by LabelFor()
        [Required(ErrorMessage = "* Required")]
        public bool ISActive { get; set; }
    }
    [MetadataType(typeof(DepartmentMetaData))]
    public partial class  TSTDepartment{ }

    public class TSTEmployeesStatuses
    {
        [Display(Name = "Employee Status")]//Used by LabelFor()
        [StringLength(25, ErrorMessage = "Status must be of 25 characters or less")]
        [Required(ErrorMessage = "* Required")]
        public string EmployeeStatusName { get; set; }

        [Display(Name = "Description")]//Used by LabelFor()
        [StringLength(140, ErrorMessage = "Description must be of 140 characters or less")]
        [Required(ErrorMessage = "* Required")]
        public string EmployeeStatusDescription { get; set; }
    }
    [MetadataType(typeof(DepartmentMetaData))]

    public partial class TSTEmployeeStatus { }

    public class TechNoteMetaData
    {
        public int TechID { get; set; }
        public string TechNoteNotation { get; set; }
        public string TechNoteDate { get; set; }
        public int TechNotesID { get; set; }
        public int TicketID { get; set; }
    }
    [MetadataType(typeof(TechNoteMetaData))]
    public partial class TSTTechNote { }

    public class PriorityMetaData
    {

        public int TicketPriorityID { get; set; }
        public string TicketPriorityName { get; set; }
        public string TicketPriorityDescription { get; set; }
    }
    [MetadataType(typeof(PriorityMetaData))]
    public partial class TSTPriority { }

    public class TicketMetaData
    {
        public string TicketSubject { get; set; }
        public string TicketDescription { get; set; }
        public int TicketSubmittedByID { get; set; }
        public System.DateTime TicketDateSubmitted { get; set; }
        public System.DateTime TicketLastUpdated { get; set; }
        public Nullable<System.DateTime> TicketResolved { get; set; }
        public int TicketSatusID { get; set; }
        public string TicketScreenShot { get; set; }
        public int TicketPriorityID { get; set; }
        public Nullable<int> TicketAssignedTech { get; set; }
        public int TicketID { get; set; }
    }
    [MetadataType(typeof(TicketMetaData))]
    public partial class TSTTicket { }

    public class TicketStatusMetaData
    {

        public int TicketStatusID { get; set; }
        public string TicketStatusName { get; set; }
        public string Description { get; set; }
    }
    [MetadataType(typeof(TicketStatusMetaData))]
    public partial class TSTTicketStatus { }
}
