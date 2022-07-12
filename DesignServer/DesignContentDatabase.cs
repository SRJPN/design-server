using System;
using System.Collections.Generic;
using System.Linq;
using DesignServer.Interfaces;

namespace DesignServer
{
    public class DesignContentDatabase : IDatabase<DesignContent>
    {
        private IList<DesignContent> designContents = new List<DesignContent>();
        public DesignContent Get(string id)
        {
            var designContent = designContents.First(x => x.ID == id);
            if(designContent == null) {
                throw new Exception($"Design id {id} not found");
            }
            return designContent;
        }

        public IList<string> GetDesignsIDsByUserId(string userId)
        {
            return designContents.Where(x => x.UserId == userId).Select(x => x.ID).ToList();
        }

        public string Strore(DesignContent obj)
        {
            obj.ID = GenerateID();
            designContents.Add(obj);
            return obj.ID;
        }

        private string GenerateID()
        {
            return Guid.NewGuid().ToString("N");
        }
    }
}