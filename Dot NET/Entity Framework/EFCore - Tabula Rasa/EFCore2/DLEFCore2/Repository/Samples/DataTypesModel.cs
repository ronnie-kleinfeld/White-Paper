﻿using DLEFCore2.Repository.Base;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using DLEFCore2.Context;

namespace DLEFCore2.Repository.Samples {
    public interface IDataTypesRepository : IRepository<DataTypesModel> {
    }
    public class DataTypesRepository(DLEFCoreContext context) : BaseRepository<DataTypesModel>(context), IDataTypesRepository {
    }

    public class DataTypesMap : IEntityTypeConfiguration<DataTypesModel> {
        public void Configure(EntityTypeBuilder<DataTypesModel> builder) {
        }
    }

    public class DataTypesModel : BaseEntityModel {
        /// <summary>
        ///  sql identity with auto incerement of 1,1
        /// </summary>
        public int Id {
            get; set;
        }

        /// <summary>
        /// nullable ?
        /// </summary>
        public string? field {
            get; set;
        }

        /// <summary>
        /// nvarchar(max)
        /// </summary>
        public string NVarChar1 {
            get; set;
        }

        /// <summary>
        /// nvarchar(257)
        /// </summary>
        [MaxLength(257)]
        public string NVarChar2 {
            get; set;
        }

        /// <summary>
        /// boolean
        /// </summary>
        public bool Boolean1 {
            get; set;
        }
        /// <summary>
        /// nullable boolean
        /// </summary>
        public bool? Boolean2 {
            get; set;
        }

        /// <summary>
        /// datetime2 - 01/01/0000-31/12/9999
        /// </summary>
        public DateTime CreatedDateTime {
            get; set;
        }

        /// <summary>
        /// integer
        /// </summary>
        public int Integer {
            get; set;
        }
        /// <summary>
        /// bigint
        /// </summary>
        public long Bigint {
            get; set;
        }

        /// <summary>
        /// decimal(18,2)
        /// </summary>
        public decimal Decimal {
            get; set;
        }
        /// <summary>
        /// float
        /// </summary>
        public double Float {
            get; set;
        }
        /// <summary>
        /// real
        /// </summary>
        public float Real {
            get; set;
        }
    }
}