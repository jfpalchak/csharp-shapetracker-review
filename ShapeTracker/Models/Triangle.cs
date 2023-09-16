using System.Collections.Generic; // using directive for our use of the class List<T>

// Models is the standard name in C# to describe 'business logic'!
namespace ShapeTracker.Models
{
  public class Triangle
  {
    // These are 'fields' (or, as they are known in JavaScript terms, properties)
    // NOTE that PRIVATE internal fields are lowerCamelCase nad are preceded by an underscore
    private int _side1;
    private int _side2;
    private int _side3;
    // the class's static field, a list of all created instances of the Triangle class:
    private static List<Triangle> _instances = new List<Triangle> {};

    // To create a constructor method, we simply define a method of the same name as the class
    // (A constructor is otherwise automatically created when the class is created)
    public Triangle(int length1, int length2, int length3)
    {
      _side1 = length1;
      _side2 = length2;
      _side3 = length3;
      // each instance of Triangle will be added to the class's static field:
      _instances.Add(this); // 'this' references the object instance that's being created
    }

    // A static method
    // (Note: not following the naming convention of Get + NameOfField, but it's shortened and easy to understand)
    public static List<Triangle> GetAll()
    {
      return _instances;
    }

    // Another static method
    public static void ClearAll()
    {
      _instances.Clear();
    }

    // To access our private fields, we'll create Getter methods:
    // (The naming convention: Get + NameOfField in Pascal case)
    public int GetSide1()
    {
      return _side1;
    }
    public int GetSide2()
    {
      return _side2;
    }
    public int GetSide3()
    {
      return _side3;
    }

    // Setter methods to access and change the value of our class fields:
    // (Similar naming convention: Set + NameOfField)
    // Like getter methods, we only need to create a setter method if necessary
    public void SetSide1(int newSide)
    {
      _side1 = newSide;
    }
    public void SetSide2(int newSide)
    {
      _side2 = newSide;
    }
    public void SetSide3(int newSide)
    {
      _side3 = newSide;
    }

    // Our class method: returns a string type value (if there were no return value, we'd label it void)
    // ALSO NOTE methods are always named in Pascal case.
    public string CheckType()
    {
      if ((_side1 > (_side2 + _side3)) || (_side2 > (_side1 + _side3)) || (_side3 > (_side1 + _side2)))
      {
        return "Not a triangle.";
      }
      else if ((_side1 != _side2) && (_side1 != _side3) && (_side2 != _side3))
      {
        return "Scalene triangle.";
      }
      else if ((_side1 == _side2) && (_side1 == _side3))
      {
        return "Equilateral triangle.";
      }
      else
      {
        return "Isosceles triangle.";
      }
    }
  }
}