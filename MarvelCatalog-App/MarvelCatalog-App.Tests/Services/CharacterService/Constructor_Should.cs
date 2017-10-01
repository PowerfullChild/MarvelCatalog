﻿using Marvel_Catalog_App.Data.API.Models;
using MarvelCatalog_App.Data.Repositories;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarvelCatalog_App.Tests.Services.CharacterService
{
    [TestFixture]
    public class Constructor_Should
    {
        [Test]
        public void Throw_ArgumentNullException_When_IEfRepository_IsNull()
        {
            var mockEfRepository = new Mock<IEfRepository<CharacterDataModel>>();
            
        }
    }
}
