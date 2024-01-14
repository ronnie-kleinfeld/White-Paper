using EFCoreDL.BL.Repository.Base;
using EFCoreDL.DL.Context;
using EFCoreDL.DL.Model;

namespace EFCoreDL.BL.Repository {
    public interface IUserRepository : IRepository<UserData> {
        UserData GetUserByID(int ID);
    }
    public class UserRepository : BaseRepository<UserData>, IUserRepository {
        public UserRepository(DLContext context) : base(context) {
        }

        public UserData GetUserByID(int ID) {
            return DLContext.Users.FirstOrDefault(x => x.ID == ID);
        }
    }
}