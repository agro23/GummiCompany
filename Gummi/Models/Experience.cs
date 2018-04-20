using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gummi.Models
{
    [Table("Experiences")]
    public class Experience
    {

        [Key]
        public int ExperienceId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int LocationId { get; set; }
        public virtual Location Location { get; set; }
        //public virtual ICollection<Person> People { get; set; }

    }
}

// Randomly stored here to save for Views/Experiences/Create.cshtml cause razor hates comments
//   @Html.LabelFor(model => model.People)<br />
//@Html.DropDownList("PersonId")<br />
//

// Razor hates comments in View/Experiences/Details too
//<ul>
//@for(var i = 0; i<something.Count; i++){
//    <li>This is a person that had that experience</li>
//}
//</ul>>


//Did I mention that razor hates comments in HTML?
//<!-- @Html.LabelFor(model => model.People)<br />
//    @Html.DropDownList("People")<br />
//-->
  //This one is from Views/Experiences/Edit.cshtml