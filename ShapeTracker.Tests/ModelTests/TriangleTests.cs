using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeTracker.Models;

namespace ShapeTracker.TestTools
{
  [TestClass]
  public class TriangleTests
  {
    
    [TestMethod]
    public void TriangleConstructor_CreatesInstanceOfTriangle_Triangle()
    {
      Triangle newTriangle = new Triangle();
      // (the result we expect, the expression to be evaluated)
      Assert.AreEqual(typeof(Triangle), newTriangle.GetType());
    }

  }
}
