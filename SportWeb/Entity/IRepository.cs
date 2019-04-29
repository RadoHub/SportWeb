using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportWeb.Entity
{
    public interface IRepository <T> where T: class, new()
    {
        IQueryable<T> List { get; }
    }
}
