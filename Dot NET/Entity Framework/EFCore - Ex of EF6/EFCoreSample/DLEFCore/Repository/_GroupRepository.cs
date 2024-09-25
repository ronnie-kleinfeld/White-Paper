using DLEFCore.Context;
using DLEFCore.Repository.Base;
using DLEFCore.Repository.Base.Repository;

namespace DLEFCore.Repository {
    public interface IGroupRepository : IRepository<GroupModel> {
    }
    public class _GroupRepository : Repository<GroupModel>, IGroupRepository {
        public _GroupRepository(DLContext context) : base(context) {
        }
    }

    internal class GroupIdFluentApi : BaseIdMap<GroupModel> {
        public GroupIdFluentApi() : base("Groups") {
            Property(v => v.GroupName).IsRequired().HasMaxLength(255);
        }
    }

    public class GroupModel : BaseIdModel {
        public string GroupName {
            get; set;
        }
        public ICollection<UserModel> Users {
            get; private set;
        }

        public GroupModel() {
            Users = new HashSet<UserModel>();
        }
    }
}