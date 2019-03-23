using System;
using System.Collections.Generic;

namespace Eticaret.MvcWebUI.Models
{
    public partial class AspnetApplications
    {
        public AspnetApplications()
        {
            AspnetRoles = new HashSet<AspnetRoles>();
            AspnetUsers = new HashSet<AspnetUsers>();
        }

        public string ApplicationName { get; set; }
        public string LoweredApplicationName { get; set; }
        public Guid ApplicationId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<AspnetRoles> AspnetRoles { get; set; }
        public virtual ICollection<AspnetUsers> AspnetUsers { get; set; }
    }
}
