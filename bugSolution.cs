public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Initialize MyProperty before accessing it
        MyProperty = 0; // Or any other appropriate default value
        int value = MyProperty * 2; 
    }
}