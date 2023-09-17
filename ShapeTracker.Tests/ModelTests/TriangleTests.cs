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
      Triangle newTriangle = new Triangle(2, 3);
      // (the result we expect, the expression to be evaluated)
      Assert.AreEqual(typeof(Triangle), newTriangle.GetType());
    }

    [TestMethod]
    public void GetSide1_ReturnsSide1_Int()
    {
      // Arrange
      int length1 = 3;
      Triangle newTriangle = new Triangle(length1, 2);
      // Act
      int result = newTriangle.Side1;
      // Assert
      Assert.AreEqual(length1, result);
    }

    // test 3
    [TestMethod]
    public void SetSide1_SetsValueOfSide1_Void()
    {
      // Arrange
      Triangle newTriangle = new Triangle(3, 3);
      int newLength1 = 44;
      // Act
      newTriangle.Side1 = newLength1;
      // Assert
      Assert.AreEqual(newLength1, newTriangle.Side1);
    }

    // test 4
    [TestMethod]
    public void GetSide2_ReturnsSide2_Int()
    {
      // arrange
      int length2 = 3;
      Triangle newTriangle = new Triangle(2, length2);
      // act
      int result = newTriangle.Side2;
      // assert
      Assert.AreEqual(length2, result);
    }

    // test 5
    [TestMethod]
    public void SetSide2_SetsValueOfSide2_Void()
    {
      // arrange
      Triangle newTriangle = new Triangle(3, 4);
      int newLength2 = 6;
      // act
      newTriangle.Side2 = newLength2;
      // assert
      Assert.AreEqual(newLength2, newTriangle.Side2);
    }
  }
}
