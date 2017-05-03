using System.Collections.Generic;

namespace TheProject.core.Entity
{
    public class Tree : BaseEntity
    {
        public int ParentId { get; set; }
        public string Description { get; set; }
    }
    public class NestedTree : BaseEntity
    {
        public int ParentId { get; set; }
        public string Description { get; set; }
        public List<Children> Children { get; set; }
    }
    public class Children : BaseEntity
    {
        public int ParentId { get; set; }
        public string Description { get; set; }
        public List<Tree> GrandChildren { get; set; }
    }
}
