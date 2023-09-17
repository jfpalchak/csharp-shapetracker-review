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
      Triangle newTriangle = new Triangle(2, 3, 8);
      // (the result we expect, the expression to be evaluated)
      Assert.AreEqual(typeof(Triangle), newTriangle.GetType());
    }

    [TestMethod]
    public void GetSide1_ReturnsSide1_Int()
    {
      // Arrange
      int length1 = 3;
      Triangle newTriangle = new Triangle(length1, 2, 8);
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
      Triangle newTriangle = new Triangle(3, 3, 8);
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
      Triangle newTriangle = new Triangle(2, length2, 8);
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
      Triangle newTriangle = new Triangle(3, 4, 8);
      int newLength2 = 6;
      // act
      newTriangle.Side2 = newLength2;
      // assert
      Assert.AreEqual(newLength2, newTriangle.Side2);
    }

    // test 6
    [TestMethod]
    public void GetSide3_ReturnsSide3_Int()
    {
      // arrange
      int length3 = 55;
      Triangle newTriangle = new Triangle(2, 3, length3);
      // act
      int result = newTriangle.GetSide3();
      // assert
      Assert.AreEqual(length3, result);
    }

    // test 7
    [TestMethod]
    public void SetSide3_SetsValueOfSide3_Void()
    {
      // arrange
      Triangle newTriangle = new Triangle(3, 4, 8);
      int newLength3 = 6;
      // act
      newTriangle.SetSide3(newLength3);
      // assert
      Assert.AreEqual(newLength3, newTriangle.GetSide3());
    }

    // test 8
    // CHECK TYPE METHOD
    [TestMethod]
    public void CheckType_DeterminesWhenNotATriangle_String()
    {
      // arrange
      Triangle notATriangle = new Triangle(3, 4, 88);
      // act
      string triType = notATriangle.CheckType();
      // assert
      Assert.AreEqual("not a triangle", triType);
    }

    // test 9
    [TestMethod]
    public void CheckType_DeterminesWhenScalene_String()
    {
      // arrange
      Triangle scaleneTri = new Triangle(3, 4, 5);
      // act
      string triType = scaleneTri.CheckType();
      // assert
      Assert.AreEqual("scalene triangle", triType);
    }

    // test 10
    [TestMethod]
    public void CheckType_DeterminesWhenIsosceles_String()
    {
      // arrange
      Triangle isoscelesTri = new Triangle(5, 4, 4);
      // act
      string triType = isoscelesTri.CheckType();
      // assert
      Assert.AreEqual("isosceles triangle", triType);
    }
  }
}
