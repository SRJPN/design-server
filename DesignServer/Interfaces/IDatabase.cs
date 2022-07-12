using System.Collections.Generic;

namespace DesignServer.Interfaces
{
    public interface IDatabase<T>
    {
        T Get(string id);

        string Strore(T obj);
        IList<string> GetDesignsIDsByUserId(string userId);
    }
}