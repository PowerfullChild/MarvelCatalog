﻿using MarvelCatalog_App.Data.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Marvel_Catalog_App.Data.Models;
using MarvelCatalog_App.Data.Repositories;
using Bytes2you.Validation;

namespace MarvelCatalog_App.Services
{
    public class CreatorsService : ICreatorsService
    {
        private readonly IEfRepository<CreatorsDataModel> creatorsRepository;
        private readonly IUnitOfWork unitOfWork;

        public CreatorsService(IUnitOfWork unitOfWork, IEfRepository<CreatorsDataModel> creatorsRepository)
        {
            Guard.WhenArgument(unitOfWork, nameof(unitOfWork)).IsNull().Throw();
            Guard.WhenArgument(creatorsRepository, nameof(creatorsRepository)).IsNull().Throw();

            this.unitOfWork = unitOfWork;
            this.creatorsRepository = creatorsRepository;
        }

        public IEnumerable<CreatorsDataModel> GetCreators()
        {
            var wantedCreators = this.creatorsRepository.All
                                    .Where(c => c.isDeleted == false && c.Image != null);

            return wantedCreators;
        }
    }
}
