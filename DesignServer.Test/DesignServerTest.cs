using Xunit;

namespace DesignServer.Test
{
    public class DesignServerTest
    {
        [Fact]
        public void CreateDesign_ShouldStoreTheDesignContentAndReturnId()
        {
            var database = new DesignContentDatabase();

            var server = new DesignServer(database);

            AuthContext authContext = new AuthContext("sooraj");
            var id = server.CreateDesign(authContext, "designContent 1");

            Assert.NotNull(id);
            
            DesignContent designContent = database.Get(id);
            
            Assert.Equal(id, designContent.ID);
            Assert.Equal("designContent 1", designContent.Content);
            Assert.Equal(authContext.userId, designContent.UserId);
        }
    }
}