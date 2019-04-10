using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MeyerIndustriesWebsite.Models
{
    public class Register
    {
        public string Email { get; set; }
        public string EmailConfirm { get; set; }
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }

        public List<SelectListItem> ItemCountry { get;set; }
        public List<SelectListItem> ItemState { get; set; }

        public Register() {
            List<SelectListItem> items1 = new List<SelectListItem>()
            {
                new SelectListItem {Text="Illinois", Value="IL", Selected=true},
                new SelectListItem {Text="Alabama", Value="AL", Selected=true},
                new SelectListItem {Text="Texas", Value="TX", Selected=true},
            };
            ItemCountry = items1;

            List<SelectListItem> items2 = new List<SelectListItem>();
            SelectListItem si2 = new SelectListItem { Text = "N/A", Value = "N/A" };
            items2.Add(new SelectListItem { Text = "Illinois", Value = "IL" });
            items2.Add(new SelectListItem { Text = "Alaska", Value = "AK" });
            si2.Text = "New text";

            ItemState = items2;
        }

    }
}