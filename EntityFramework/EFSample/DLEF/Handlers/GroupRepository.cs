using DLEF.Context;
using DLEF.Handlers.Base.Data;
using DLEF.Handlers.Base.Map;
using DLEF.Handlers.Base.Repository;
using System.Collections.Generic;

namespace DLEF.Handlers {
    public interface IGroupRepository : IRepository<GroupData> {
    }
    public class GroupRepository : Repository<GroupData>, IGroupRepository {
        public GroupRepository(DLContext context) : base(context) {
        }
    }

    internal class GroupIDMap : BaseIDMap<GroupData> {
        public GroupIDMap() : base("Groups") {
            Property(v => v.GroupName).IsRequired().HasMaxLength(255);
        }
    }

    public class GroupData : BaseIDData {
        public string GroupName { get; set; }
        public ICollection<UserData> Users { get; private set; }

        public GroupData() {
            Users = new HashSet<UserData>();
        }
    }
}