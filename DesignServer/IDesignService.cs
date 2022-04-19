namespace canva_dotnet
{
 public interface IDesignService {
    /** Creates a design and returns the design id. */
    string createDesign(AuthContext ctx, string designContent);

    /** Returns the design content, if the user has access to the design. */
    string getDesign(AuthContext ctx, string designId);
  }
}