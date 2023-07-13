
namespace MyDll
{
  public class MyClass
  {

    public enum MyEnum { Up, Down, Sideways };

    public MyClass()
    {

    }

    public MyClass(string myStringProperty)
    {
      this.MyStringProperty = myStringProperty;
    }

    private string _myStringProperty;

    public string MyStringProperty
    {
      get
      {
        return _myStringProperty;
      }
      set
      {
        _myStringProperty = value;
      }
    }

    public string Foo(string message, int count)
    {
      string result = "";
      for (int i = 0; i < count; i++)
      {
        result += message;
      }
      return result;
    }

    private void Bar()
    {

    }

  }
}
