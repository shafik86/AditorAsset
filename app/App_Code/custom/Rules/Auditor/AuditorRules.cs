using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using MyCompany.Data;

namespace MyCompany.Rules
{
    public partial class AuditorRules : MyCompany.Rules.SharedBusinessRules
    {
        public string ThisEmail
        {
            get
            {

                    return UserEmail;
            
            }
        }
    }
}
