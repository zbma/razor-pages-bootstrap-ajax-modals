using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using RazorPagesAjaxModals.Models;
using System.Collections.Generic;

namespace RazorPagesAjaxModals.Pages
{
    public class IndexModel : PageModel
    {
        private readonly static List<Contact> Contacts = new List<Contact>();

        public void OnGet()
        {

        }

        public PartialViewResult OnGetContactModalPartial()
        {
            return new PartialViewResult
            {
                ViewName = "_ContactModalPartial",
                ViewData = new ViewDataDictionary<Contact>(ViewData, new Contact { })
            };
        }

        public PartialViewResult OnPostContactModalPartial(Contact model)
        {
            if (ModelState.IsValid)
            {
                Contacts.Add(model);
            }

            return new PartialViewResult
            {
                ViewName = "_ContactModalPartial",
                ViewData = new ViewDataDictionary<Contact>(ViewData, model)
            };
        }
    }
}
