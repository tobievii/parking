using System.Collections.Generic;

namespace digital
{
    public class RoleAssignmentCreate
    {
        public string ObjectId { get; set; }
        public string ObjectIdType { get; set; }
        public string Path { get; set; }
        public string RoleId { get; set; }
        public string TenantId { get; set; }
    }
}