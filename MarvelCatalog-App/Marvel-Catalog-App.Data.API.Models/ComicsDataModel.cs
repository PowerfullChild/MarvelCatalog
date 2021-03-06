﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace Marvel_Catalog_App.Data.Models
{
    public class ComicsDataModel : DataModel
    {
        public ComicsDataModel() { }

        public ComicsDataModel(string title, string image, string description, double price, IEnumerable<CharacterDataModel> characters)
        {
            this.Title = title;
            this.Image = image;
            this.Description = description;
            this.Price = price;
            this.Characters = characters;
        }

        public string Title { get; set; }

        public string Image { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public IEnumerable<CharacterDataModel> Characters { get; set; }
    }
}
