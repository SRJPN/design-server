using System.Collections.Generic;

namespace DesignServer.Interfaces
{
 public interface IDesignService {
    /** Creates a design and returns the design id. */
    string CreateDesign(AuthContext ctx, string designContent);

    /** Returns the design content, if the user has access to the design. */
    string GetDesign(AuthContext ctx, string designId);

    /** Returns a list of design ids that the given context has access to. */
    IList<string> FindDesigns(AuthContext ctx);
  }
}