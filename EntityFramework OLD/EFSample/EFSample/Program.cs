using DLEF.Context;
using DLEF.Handlers;
using DLEF.UnitOfWork;
using System.Data.Entity;
using System.Linq;

namespace EFSample {
    class Program {
        static void Main(string[] args) {
            // without repository
            AuthorData author = new AuthorData();
            author.Name = "name";

            var dlContext = new DLContext();
            dlContext.Authors.Add(author);
            dlContext.SaveChanges();

            var users = dlContext.Users.Include(x => x.DepartmentID).ToList();

            var user = dlContext.Users.FirstOrDefault(x => x.ID == 1);
            dlContext.Departments.Where(x => x.ID == user.DepartmentID).Load();

            // with repository
            using (var unitOfWork = new UnitOfWork(new DLContext())) {
                var user1 = unitOfWork.Users.Get(1);

                var newUser = new UserData();
                newUser.UserName = "userName";
                unitOfWork.Users.Add(newUser);
                unitOfWork.Complete();

                unitOfWork.Users.Remove(newUser);
                unitOfWork.Complete();
            }

        }
    }
}