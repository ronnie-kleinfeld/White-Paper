using System.ComponentModel.DataAnnotations;

namespace DLEFCore2.Repository {
    public class UserModel {
        public int Id {
            get; set;
        }

        public string Name1 {
            get; set;
        }

        public string Name11 {
            get; set;
        }

        public string? Name2 {
            get; set;
        }
        [MaxLength(257)]
        public string Name3 {
            get; set;
        }

        public bool IsActive {
            get; set;
        }
        public bool? IsActive2 {
            get; set;
        }

        public DateTime CreatedDateTime1 {
            get; set;
        }

        public int Age1 {
            get; set;
        }
        public long Age2 {
            get; set;
        }

        public decimal value1 {
            get; set;
        }
        public double value2 {
            get; set;
        }
        public float value3 {
            get; set;
        }
    }
}