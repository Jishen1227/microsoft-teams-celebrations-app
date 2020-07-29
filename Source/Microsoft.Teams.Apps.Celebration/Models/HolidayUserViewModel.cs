using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Microsoft.Teams.Apps.Celebration.Models
{
    public class HolidayUserViewModel
    {
        public IEnumerable<string> Holidays { get; set; }

        public IEnumerable<User> Users { get; set; }
    }
}