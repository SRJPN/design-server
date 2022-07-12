using System.Collections.Generic;
using DesignServer.Interfaces;

namespace DesignServer
{
    public class DesignServer : IDesignService
    {
        private readonly IDatabase<DesignContent> database;

        public DesignServer(IDatabase<DesignContent> database)
        {
            this.database = database;
        }

        public string CreateDesign(AuthContext ctx, string designContent)
        {
            var designContent1 = new DesignContent() {
                Content = designContent,
                UserId = ctx.userId
            };
            return database.Strore(designContent1);
        }

        public IList<string> FindDesigns(AuthContext ctx)
        {
            var designContentIds = database.GetDesignsIDsByUserId(ctx.userId);

            return designContentIds;
        }

        public string GetDesign(AuthContext ctx, string designId)
        {
            var designContent = database.Get(designId);
            if(designContent.UserId != ctx.userId) {
                throw new System.Exception($"User doesnt have access to designId {designId}");
            }
            return designContent.Content;
        }
    }
}