using EFCoreDL.BL.Repository.Base;
using EFCoreDL.DL.Context;
using EFCoreDL.DL.Model;

namespace EFCoreDL.BL.Repository {
    public interface IUserRepository : IRepository<UserModel> {
        UserModel GetUserByID(int ID);
    }
    public class UserRepository : BaseRepository<UserModel>, IUserRepository {
        public UserRepository(DLContext context) : base(context) {
        }

        public UserModel GetUserByID(int ID) {
            return DLContext.Users.FirstOrDefault(x => x.ID == ID);
        }
    }
}