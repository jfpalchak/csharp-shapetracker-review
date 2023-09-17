
// Models is the standard name in C# to describe 'business logic'!
namespace ShapeTracker.Models
{
  public class Triangle
  {
    private int _side1;
    public int Side1
    {
      get { return _side1; }
    }

    public Triangle(int length1)
    {
      _side1 = length1;
    }
  }
}