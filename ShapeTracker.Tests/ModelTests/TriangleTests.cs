using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeTracker.Models;

namespace ShapeTracker.TestTools
{
  [TestClass]
  public class TriangleTests
  {
    
    [TestMethod]
    // the test naming convention:
    // NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue
    public void TriangleConstructor_CreatesInstanceOfTriangle_Triangle()
    {
      Triangle newTriangle = new Triangle(2);
      // (the result we expect, the expression to be evaluated)
      Assert.AreEqual(typeof(Triangle), newTriangle.GetType());
    }

    [TestMethod]
    public void GetSide1_ReturnsSide1_Int()
    {
      // Arrange
      int length1 = 3;
      Triangle newTriangle = new Triangle(length1);
      // Act
      int result = newTriangle.Side1;
      // Assert
      Assert.AreEqual(length1, result);
    }

  }
}
