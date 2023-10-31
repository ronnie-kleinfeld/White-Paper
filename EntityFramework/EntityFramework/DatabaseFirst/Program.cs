using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirst {
    class Program {
        static void Main(string[] args)
        {
            var context = new DatabaseFirst.SRYCRMDBEntities();
            var log =  new LogTypesEnum();
            log.ID = 1;
            log.CreateDateTime = DateTime.Now;
            log.Name = "name";
            log.Description = "description";
            log.Synonyms = "synonyms";
            log.OrderBy = -1;
            log.IsDefault = false;
            log.Disabled = false;

            context.LogTypesEnums.Add(log);
            context.SaveChanges();
        }
    }
}
