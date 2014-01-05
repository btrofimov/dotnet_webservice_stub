using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MvcApplication3.ViewModels
{
    public class ViewUser
    {
        public virtual int Id { get; set; }

        [DisplayName("First Name")]
        [Required(ErrorMessage = "First Name is required")]
        public virtual string FirstName { get; set; }
    }
}