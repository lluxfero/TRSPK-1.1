string s;

Console.WriteLine("======Man======");
var FirstMan = new Man();
s = FirstMan.ToString();
Console.WriteLine(s);

Console.WriteLine("======Teenager======");
var FirstTeenager = new Teenager();
s = FirstTeenager.ToString();
Console.WriteLine(s);

Console.WriteLine("======Worker======");
var FirstWorker = new Worker();
s = FirstWorker.ToString();
Console.WriteLine(s);

Console.WriteLine("\nPress <Enter>");
Console.ReadLine();

class Man
{
    public string? name;
    public int age;
    public Man()
    {
        SetName();
        SetAge();
    }
    public void SetName()
    {
        Console.Write("Введите имя: ");
        name = Console.ReadLine();
        while (string.IsNullOrEmpty(name))
        {
            Console.Write("Ошибка! Попробуйте еще раз: ");
            name = Console.ReadLine();
        }
    }
    public virtual void SetAge()
    {
        Console.Write("Введите возраст: ");
        bool f = true;
        string? t = Console.ReadLine();
        while (f)
        {
            try
            {
                age = Convert.ToInt32(t);
                if (age < 0) throw new Exception();
                else f = false;
            }
            catch
            {
                Console.Write("Ошибка! Попробуйте еще раз: ");
                t = Console.ReadLine();
            }
        }
    }
    public override string ToString()
    {
        return $"Человек, {name}, {age}";
    }
}

class Teenager : Man
{
    public string? school;
    public Teenager()
    {
        SetSchool();
    }
    public void SetSchool()
    {
        Console.Write("Введите школу: ");
        school = Console.ReadLine();
    }
    public override void SetAge()
    {
        Console.Write("Введите возраст: ");
        bool f = true;
        string? t = Console.ReadLine();
        while (f)
        {
            try
            {
                age = Convert.ToInt32(t);
                if (age < 13 || age > 19) throw new Exception();
                else f = false;
            }
            catch
            {
                Console.Write("Ошибка! Попробуйте еще раз: ");
                t = Console.ReadLine();
            }
        }
    }
    public override string ToString()
    {
        return $"Подросток, {name}, {age}, Место учебы: {school}";
    }
}
class Worker : Man
{
    public string? work;
    public Worker()
    {
        SetWork();
    }
    public void SetWork()
    {
        Console.Write("Введите место работы: ");
        work = Console.ReadLine();
    }
    public override void SetAge()
    {
        Console.Write("Введите возраст: ");
        bool f = true;
        string? t = Console.ReadLine();
        while (f)
        {
            try
            {
                age = Convert.ToInt32(t);
                if (age < 16 || age > 70) throw new Exception();
                else f = false;
            }
            catch
            {
                Console.Write("Ошибка! Попробуйте еще раз: ");
                t = Console.ReadLine();
            }
        }
    }
    public override string ToString()
    {
        return $"Работник, {name}, {age}, Место работы: {work}";
    }
}
