using DMR.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DMR.WebApp.Services
{
    public interface IAuditService
    {
        Guid Who { get; set; }
        char What { get; set; }
        DateTime When { get; set; }
    }


    public class AuditService : IAuditService
    {
        public AuditService(IAuditService audit)
        {
            Who = audit.Who;
            What = audit.What;
            When = audit.When;
        }

        public Guid Who { get; set; }       // UserId
        public char What { get; set; }      // Action (CRUD)
        public DateTime When { get; set; }  // Timestamp
    }
}
