using EFCoreDL.BL.UnitOfWork;
using EFCoreDL.DL.Context;
using EFCoreDL.DL.Model;

namespace EFCoreDL {
    internal class Program {
        static void Main(string[] args) {
            using (var unitOfWork = new UnitOfWork(new DLContext())) {
                //DepartmentTypeModel departmentType = new DepartmentTypeData() {
                //    Name = "IT",
                //    Description = "Information Technology"
                //};
                //unitOfWork.Departments.Add(departmentType);
                //unitOfWork.Complete();

                DepartmentTypeModel departmentType = unitOfWork.Departments.GetAll().First();

                unitOfWork.Users.Add(new UserModel() {
                    UserName = "Emma",
                    FirstName = "Emma",
                    LastName = "Watson",
                    DepartmentType = departmentType
                });
                unitOfWork.Users.Add(new UserModel() {
                    UserName = "trump",
                    FirstName = "Trump",
                    LastName = "Donald",
                    DepartmentType = departmentType
                });
                unitOfWork.Complete();

                //unitOfWork.Users.Remove(newUser);
                //unitOfWork.Complete();
            }

            var dlContext = new DLContext();
            foreach (UserModel user in dlContext.Users) {
                Console.WriteLine($"{user.ID} {user.UserName} {user.CreatedDateTime}");
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}