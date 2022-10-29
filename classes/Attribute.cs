namespace attribute;

public class MyAttribute : Attribute
{
    public string Comment { get; set; }
    public MyAttribute(string message) => Comment = message;
}