using DLEFCore.Context;
using DLEFCore.Repository;
using DLEFCore.UnitOfWork;

namespace EFCoreSample {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello, World!");

            //// without repository
            //AuthorModel author = new AuthorModel();
            //author.Name = "John Grisham";
            //author.CreatedDateTime = DateTime.Now;

            //var dlContext = new DLContext();
            //dlContext.Authors.Add(author);
            //dlContext.SaveChanges();

            //foreach (AuthorModel a in dlContext.Authors)
            //{
            //    Console.WriteLine(a.Name);
            //}
            //Console.ReadKey();

            //var users = dlContext.Users.Include(x => x.DepartmentID).ToList();

            //var user = dlContext.Users.FirstOrDefault(x => x.Id == 1);
            //dlContext.Departments.Where(x => x.Id == user.DepartmentID).Load();

            // with repository
            using (var unitOfWork = new UnitOfWork(new DLContext())) {
                NameIdModel name = new NameIdModel();
                name.Id = 17;
                name.NameId = "Ronnie";
                unitOfWork.NameIds.Add(name);
                unitOfWork.Complete();

                //unitOfWork.Users.Remove(newUser);
                //unitOfWork.Complete();
            }

            var dlContext = new DLContext();
            foreach (NameIdModel model in dlContext.NameIds) {
                Console.WriteLine(model.NameId);
            }

            foreach (NameIdModel model in dlContext.NameIds) {
                Console.WriteLine(model.NameId);
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}