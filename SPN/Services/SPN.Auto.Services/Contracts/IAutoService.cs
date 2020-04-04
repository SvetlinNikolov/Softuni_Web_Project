using System;
using System.Collections.Generic;
using System.Text;

namespace SPN.Auto.Services.Contracts
{
    public interface IAutoService
    {
        IEnumerable<T> GetAll<T>(int? count = null);

        T GetByName<T>(string name);

        T GetById<T>(int id);
    }
}
