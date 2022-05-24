using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Security;
using MyCompany.Data;
using MyCompany.Models;

namespace MyCompany.Rules
{
    public partial class AuditorAdminBusinessRules : MyCompany.Rules.SharedBusinessRules
    {

        /// <summary>This method will execute in any view after an action
        /// with a command name that matches "Insert".
        /// </summary>
        [Rule("r101")]
        public void r101Implementation(AuditorAdminModel instance)
        {
            // This is the placeholder for method implementation.
            var user = Membership.CreateUser(instance.Name, instance.Password, instance.Email);
            SqlText.ExecuteNonQuery("UPDATE Users SET AuditorID = @p0 WHERE UserID = @p1",
                instance.AuditorID, user.ProviderUserKey);
            if (Roles.RoleExists("Auditor"))
            {
                Roles.AddUserToRole(instance.Name, "Auditor");
            }
            else
            {
                Roles.CreateRole("Auditor");
                Roles.AddUserToRole(instance.Name, "Auditor");
            }
        }
    }
}
