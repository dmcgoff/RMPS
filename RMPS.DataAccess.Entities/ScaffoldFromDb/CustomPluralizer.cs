﻿using Microsoft.EntityFrameworkCore.Design;

namespace RMPS.DataAccess.Entities
{
    public class CustomPluralizer : IPluralizer
    {
        public string Pluralize(string name)
        {
            return Inflector.Inflector.Pluralize(name) ?? name;
        }
        public string Singularize(string name)
        {
            return Inflector.Inflector.Singularize(name) ?? name;
        }
    }
}
