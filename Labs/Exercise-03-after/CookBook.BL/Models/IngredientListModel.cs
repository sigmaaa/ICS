﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CookBook.BL.Models
{
    public class IngredientListModel : ModelBase
    {
        public string Name { get; set; }

        private sealed class NameEqualityComparer : IEqualityComparer<IngredientListModel>
        {
            public bool Equals(IngredientListModel x, IngredientListModel y)
            {
                if (ReferenceEquals(x, y)) return true;
                if (ReferenceEquals(x, null)) return false;
                if (ReferenceEquals(y, null)) return false;
                if (x.GetType() != y.GetType()) return false;
                return x.Name == y.Name;
            }

            public int GetHashCode(IngredientListModel obj) => HashCode.Combine(obj.Id, obj.Name);
        }

        public static IEqualityComparer<IngredientListModel> AllMembersComparer { get; } = new NameEqualityComparer();
    }
}
