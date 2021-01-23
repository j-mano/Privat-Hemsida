using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Joachim_Hemsida.Models
{
    public class FrontendProjectListModel
    {
        [Display(Name = "DatabasID")]
        public int idInDatabase { get; set; }

        [Display(Name="Projekt namn")]
        [StringLength(100, MinimumLength = 2, ErrorMessage ="För kort namn")]
        [Required(ErrorMessage = "Var snäll och skriv in ditt namn")]
        public string projectName { get; set; }

        [Display(Name = "Påbörjat datum")]
        [Required(ErrorMessage = "Var snäll och skriv in dit ett datum")]
        public DateTime initalDate { get; set; }

        [Display(Name = "Sist uppdaterat datum")]
        [Required(ErrorMessage = "Var snäll och skriv in dit ett datum")]
        public DateTime lastUpdatedDate { get; set; }

        [Display(Name = "ProjektBeskrivning")]
        public string projectDescription { get; set; }

        [Display(Name = "Programerings Språk")]
        [Required(ErrorMessage = "Var snäll och lägg till språk är du snäll.")]
        public string programingLangugeWritenwidth { get; set; }

        [Display(Name = "Webbsida Länk")]
        public string WebsiteLink { get; set; }
    }
}
