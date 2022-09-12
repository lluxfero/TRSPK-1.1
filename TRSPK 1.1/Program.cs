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


Console.WriteLine("======StringList======");
var FirstStringList = new StringList();
FirstStringList.Insert("1");
FirstStringList.Insert("2");    
FirstStringList.Insert("3");    
FirstStringList.Insert("4");    
FirstStringList.Insert("5");
FirstStringList.Insert("6");
FirstStringList.Print();

Console.WriteLine("_Delete(4)");
FirstStringList.Delete(4);
FirstStringList.Print();

Console.WriteLine("_Search(\"3\")");
Console.WriteLine(FirstStringList.Search("3"));

Console.WriteLine("_Update(1, \"7\")");
FirstStringList.Update(1, "7");
FirstStringList.Print();

Console.WriteLine("_GetAt(0)");
Console.WriteLine(FirstStringList.GetAt(0));


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

class StringList
{
    public int size;
    string[] masstr = new string[100];
    public void Insert(string s) 
    {
        masstr[size] = s;
        size++;
    }
    public void Delete(int n)
    {
        if (n >= 0 && n < size)
        {
            for (int i = n; i < size - 1; i++)
                masstr[i] = masstr[i + 1];
            size--;
        }
        else Console.WriteLine($"Ошибка! Элемента с индексом {n} нет");
    }
    public int Search(string s)
    {
        for (int i = 0; i < size; i++)
            if (masstr[i] == s) return i;
        return -1;
    }
    public void Update(int n, string s)
    {
        if (n >= 0 && n < size) masstr[n] = s;
        else Console.WriteLine($"Ошибка! Элемента с индексом {n} нет");
    }
    public string GetAt(int n)
    {
        if (n >= 0 && n < size) return masstr[n];
        return null;
    }
    public void Print()
    {
        Console.WriteLine("__print__");
        for (int i = 0; i < size; i++)
            Console.WriteLine($"Индекс {i}, Значение: {masstr[i]}, Размер: {size}");
    }
}