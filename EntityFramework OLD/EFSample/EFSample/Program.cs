using DLEF.Context;
using DLEF.Handlers;
using DLEF.UnitOfWork;
using System;

namespace EFSample {
    class Program {
        static void Main(string[] args) {
            //// without repository
            //AuthorData author = new AuthorData();
            //author.Name = "John Grisham";
            //author.CreatedDateTime = DateTime.Now;

            //var dlContext = new DLContext();
            //dlContext.Authors.Add(author);
            //dlContext.SaveChanges();

            //foreach (AuthorData a in dlContext.Authors)
            //{
            //    Console.WriteLine(a.Name);
            //}
            //Console.ReadKey();

            //var users = dlContext.Users.Include(x => x.DepartmentID).ToList();

            //var user = dlContext.Users.FirstOrDefault(x => x.ID == 1);
            //dlContext.Departments.Where(x => x.ID == user.DepartmentID).Load();

            // with repository
            using (var unitOfWork = new UnitOfWork(new DLContext())) {
                AuthorData author = new AuthorData();
                author.Name = "Emma";
                unitOfWork.Authors.Add(author);
                unitOfWork.Complete();

                //unitOfWork.Users.Remove(newUser);
                //unitOfWork.Complete();
            }

            var dlContext = new DLContext();
            foreach (AuthorData a in dlContext.Authors) {
                Console.WriteLine(a.Name);
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}