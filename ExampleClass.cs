using System;


public class ExampleClass {
    private string HelloText;

    public ExampleClass(string input) {
        HelloText = input;
    }

    public void sayHello() {
        Console.WriteLine(HelloText);
    }
}