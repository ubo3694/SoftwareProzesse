using System;

public class SimpleAdder {

    public int Add(int a, int b) {
        return a + b;
    }
}

public class Program {
    public static void Main(string[] args) {
        SimpleAdder adder = new SimpleAdder();
        Console.WriteLine("Test: " + (adder.Add(3, 4) == 7));
    }
}