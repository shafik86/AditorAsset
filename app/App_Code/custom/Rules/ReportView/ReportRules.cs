using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using MyCompany.Data;

namespace MyCompany.Rules
{
    public partial class ReportRules : MyCompany.Rules.SharedBusinessRules
    {
        public string LoginId
        {
            get
            {
                
                return UserEmail;

            }
        }
    }
}
