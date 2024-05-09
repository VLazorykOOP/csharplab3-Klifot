using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Choose the task1 or task2");
        string input = Console.ReadLine();
        int taskNumber;

        if (int.TryParse(input, out taskNumber) && taskNumber >= 1 && taskNumber <= 2)
        {
            switch (taskNumber)
            {
                case 1:
                    Task1();
                    break;
                case 2:
                    Task2();
                    break;
            }
        }
        else
        {
            Console.WriteLine("Номер завдання повинен бути від 1 до 2.");
        }
    }

    static void Task1()
    {
        Romb romb = new Romb(5, 7, 1);
        romb.DisplayLengths();
        Console.WriteLine($"Периметр: {romb.CalculatePerimeter()}");
        Console.WriteLine($"Площа: {romb.CalculateArea()}");
        Console.WriteLine($"Чи є квадратом: {romb.IsSquare()}");
    }

    static void Task2()
    {
        Detail detail = new Detail("Detail1", 100);
        Mechanism mechanism = new Mechanism("Mechanism1", 200, "Engine");
        Product product = new Product("Product1", 300, "Car");
        Node node = new Node("Node1", 400, "Wheel");

        BaseClass[] array = new BaseClass[] { detail, mechanism, product, node };

        foreach (var item in array)
        {
            item.Show();
        }
    }
}

public class BaseClass
{
    public string Name { get; set; }
    public int Weight { get; set; }

    public BaseClass(string name, int weight)
    {
        Name = name;
        Weight = weight;
    }

    public virtual void Show()
    {
        Console.WriteLine($"Name: {Name}, Weight: {Weight}");
    }
}

public class Detail : BaseClass
{
    public Detail(string name, int weight) : base(name, weight) { }
}

public class Mechanism : BaseClass
{
    public string Type { get; set; }

    public Mechanism(string name, int weight, string type) : base(name, weight)
    {
        Type = type;
    }

    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Type: {Type}");
    }
}

public class Product : BaseClass
{
    public string ProductType { get; set; }

    public Product(string name, int weight, string productType) : base(name, weight)
    {
        ProductType = productType;
    }

    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Product Type: {ProductType}");
    }
}

public class Node : BaseClass
{
    public string NodeType { get; set; }

    public Node(string name, int weight, string nodeType) : base(name, weight)
    {
        NodeType = nodeType;
    }

    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Node Type: {NodeType}");
    }
}

public class Romb
{
    // Захищені поля
    protected int a, d1, c;

    // Конструктор
    public Romb(int a, int d1, int c)
    {
        this.a = a;
        this.d1 = d1;
        this.c = c;
    }

    // Метод для виведення довжин на екран
    public void DisplayLengths()
    {
        Console.WriteLine($"Сторона: {a}, Діагональ: {d1}");
    }

    // Метод для розрахунку периметра ромба
    public double CalculatePerimeter()
    {
        return 4 * a;
    }

    // Метод для розрахунку площі ромба
    public double CalculateArea()
    {
        return 0.5 * a * d1;
    }

    // Метод, що дозволяє встановити, чи є даний ромб є квадратом
    public bool IsSquare()
    {
        return a == d1;
    }

    // Властивості
    public int Side
    {
        get { return a; }
        set { a = value; }
    }

    public int Diagonal
    {
        get { return d1; }
        set { d1 = value; }
    }

    public int Color
    {
        get { return c; }
        set { c = value; }
    }
}
