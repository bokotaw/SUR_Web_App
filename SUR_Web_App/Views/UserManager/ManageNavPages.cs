using Microsoft.AspNetCore.Mvc.Rendering;

namespace SUR_Web_App.Views.UserRoles
{
    public class ManageNavPages
    {
        public static string ManageUser => "Manageuser";
        public static string Email => "Email";
        public static string ChangePassword => "ChangePassword";
        public static string DeleteData => "DeleteData";
        public static string ManageUserNavClass(ViewContext viewContext) => PageNavClass(viewContext, ManageUser);
        public static string EmailNavClass(ViewContext viewContext) => PageNavClass(viewContext, Email);
        public static string ChangePasswordNavClass(ViewContext viewContext) => PageNavClass(viewContext, ChangePassword);
        public static string DeleteDataNavClass(ViewContext viewContext) => PageNavClass(viewContext, DeleteData);

        public static string PageNavClass(ViewContext viewContext, string page)
        {
            var activePage = viewContext.ViewData["ActivePage"] as string
                ?? System.IO.Path.GetFileNameWithoutExtension(viewContext.ActionDescriptor.DisplayName);
            return string.Equals(activePage, page, StringComparison.OrdinalIgnoreCase) ? "active" : null;
        }

    }
}
