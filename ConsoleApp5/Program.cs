enum Gender { Male,Female};
class Animals
{
    public string? _nickname { get; set; }
    public int? _age { get; set; }
    public Gender? _gender { get; set; }
    public int? _energy { get; set; }
    public float? _amount { get; set; }
    public int? _mealquality { get; set; }  

    public Animals(string nickname,int age,Gender gender,int energy,float amount,int mealquality)
    {
        _nickname = nickname;
        _age = age;
        _gender = gender;
        _energy = energy;
        _amount = amount;
        _mealquality = mealquality;
    }
    virtual public void Eat() { }
    virtual public void Sleep() { }
    virtual public void Play() { }

    virtual public void show()
    {
        Console.WriteLine($"Nickname -- {_nickname}\nAge -- {_age}\nGender -- {_gender}\nEnergy -- {_energy}\nPrice -- {_amount}\nMeal Quality -- {_mealquality}");
    }
}

class Cat:Animals
{
    public string? _meow { get; set;}

    public Cat(string meow, string nickname,int age,Gender gender,int energy,float amount,int mealquality)
        :base(nickname,age,gender,energy,amount,mealquality)
    {
        _meow = meow;
    }

    public override void Sleep()
    {
        if(_energy >=100)
            Console.WriteLine("the Cat does not want to sleep");
        else
            Console.WriteLine("cat sleeping");
        _energy +=20;

        Console.WriteLine($"Cat energy is {_energy}");
    }
    public override void Eat()
    {
        if(_energy <= 0)
            Console.WriteLine("the Cat does not to play");
        else
            Console.WriteLine("Cat is playing");
        _energy -=10;

        Console.WriteLine($"Cat energy is {_energy}");
    }

    public override void show()
    {
        Console.WriteLine($"Nickname -- {_nickname}\nAge -- {_age}\nGender -- {_gender}\nEnergy -- {_energy}\nPrice -- {_amount}\nMeal Quality -- {_mealquality} ");

    }
}

class Dog : Animals
{
    public string _bark { get; set; }
    public Dog(string bark, string nickname, int age, Gender gender, int energy, float amount, int mealquality)
        : base(nickname, age, gender, energy, amount, mealquality)
    {
        _bark = bark;
    }

    public override void Eat()
    {
        if (_energy == 100)
            Console.WriteLine("The dog does not want to eat");
        else
            Console.WriteLine("Dog eating");
        _energy += 20;
        Console.WriteLine($"Dog energy is {_energy}");
    }

    public override void Sleep()
    {
        if (_energy == 100)
            Console.WriteLine("The dog does not want to sleep");
        else
            Console.WriteLine("Dog sleeping");
        _energy += 20;
        Console.WriteLine($"Dog energy is {_energy}");
    }

    public override void Play()
    {
        if (_energy <= 0)
            Console.WriteLine("The dog does not want to play");
        else
            Console.WriteLine("Dog playing");
        _energy -= 10;
        Console.WriteLine($"Dog energy is {_energy}");
    }

    public override void show()
    {
        Console.WriteLine($"Nickname -- {_nickname}\nAge -- {_age}\nGender -- {_gender}\nEnergy -- {_energy}\nAmount --  {_amount}\nMeal Quality -- {_mealquality}");
    }
}

class Bird:Animals
{
    public string _hawing { get; set; }
    
    public Bird(string hawing,string nickname,int age,Gender gender,int energy,float amount,int mealquality)
        :base(nickname,age,gender,energy,amount,mealquality)
    {
        _hawing = hawing;   
    }

    public override void Eat()
    {
        if(_energy == 100)
            Console.WriteLine("The bird does not to eat");
        else
            Console.WriteLine("Bird eating");
        _energy +=20;

        Console.WriteLine($"BIrd energy is {_energy}");
    }

    public override void Sleep()
    {
        if (_energy == 100)
            Console.WriteLine("The bird does not to sleep");
        else
            Console.WriteLine("Bird sleeping");
        _energy +=20;

        Console.WriteLine($"BIrd energy is {_energy}");
    }

    public override void Play()
    {
        if(_energy <= 0)
            Console.WriteLine("The bird does not want to play");
        else
            Console.WriteLine("Bird is playing");
        _energy -= 10;

        Console.WriteLine($"Nickname -- {_nickname}\nAge -- {_age}\nGender -- {_gender}\nEnergy -- {_energy}\nAmount -- {_amount}\nMealquality -- {_mealquality}");
    }

}

class Fish:Animals
{
public string _hasswim { get; set; }
    public Fish(string hasswim,string nickname,int age,Gender gender,int energy,float amount,int mealquality)
        :base(nickname,age,gender,energy,amount,mealquality)
    {
        _hasswim = hasswim;
    }
    public override void Eat()
    {
        if(_energy == 100 )
            Console.WriteLine("The fish does not want to sleep");
        else
            Console.WriteLine("The Fish sleeping");
        _energy +=20;

        Console.WriteLine($"Fish energy is {_energy}");
    }

    public override void Sleep()
    {
        if (_energy == 100)
            Console.WriteLine("The fish does not want to sleep");
        else
            Console.WriteLine("The Fish sleeping");
        _energy +=20;
        Console.WriteLine($"Fish energy is {_energy}");
    }

    public override void show()
    {
        Console.WriteLine($"Nickname -- {_nickname}\nAge -- {_age}\nGender -- {_gender}\nEnergy -- {_energy}\nAmount -- {_amount}\nMeal quality -- {_mealquality}");
    }
}

class Program
{



    static void Main()
    {
        Animals[] animals =
        {
            new Cat("meow","Tom",21,Gender.Female,70,250,100),
            new Dog("haow", "maks", 13, Gender.Female, 75, 115, 100),
            new Bird("has wing", "lulu", 5, Gender.Female, 30, 111, 100),
            new Fish("has swim", "siro", 45, Gender.Male, 200, 300, 100)
        };
        Console.WriteLine("\t\tWelcome Pet Shop");
        bool start = true;
        bool start1 = true;
        int choiceAnimals;
        int choiceA;
        
        while(start)
        {
            Console.WriteLine("1 -- Cat\n2 -- Dog\n3 -- Bird\n4 -- Fish\nYour choice: ");
            int.TryParse(Console.ReadLine(), out choiceAnimals);
            if(choiceAnimals == 1)
            {
                Console.WriteLine("You select Cat");
                Console.WriteLine("1 -- Play\n2 -- Sleep\n3 -- Eat\n4 -- show\n5 -- Exit\nYour choice: ");
                int.TryParse(Console.ReadLine(),out choiceA);
                while (start1 = true)
                {
                    if(choiceA == 1)
                    {
                        animals[0].Play();
                        animals[0].show();
                    }
                    else if (choiceA == 2)
                    {
                        animals[0].Sleep();
                        break;
                    }
                    else if (choiceA == 3)
                    {
                        animals[0].Eat();
                        break;
                    }
                    else if (choiceA == 4)
                    {
                        animals[0].show();
                        break;
                    }
                    else if (choiceA == 5)
                        start1 = false;

                    else
                    {
                        Console.WriteLine("False choise");
                        break;
                    }
                }

            }
            else if (choiceAnimals == 2)
            {
                Console.WriteLine("You select Dog");
                Console.WriteLine("1 -- Play\n2 -- Sleep\n3 -- Eat\n4 -- show\n5 --exit\nyour choise: ");
                int.TryParse(Console.ReadLine(), out choiceA);

                while (start1 == true)
                {
                    if (choiceA == 1)
                    {
                        animals[1].Play();
                        animals[1].show();
                        break;
                    }
                    else if (choiceA == 2)
                    {
                        animals[1].Sleep();
                        break;
                    }
                    else if (choiceA == 3)
                    {
                        animals[1].Eat();
                        break;
                    }
                    else if (choiceA == 4)
                    {
                        animals[1].show();
                        break;
                    }
                    else if (choiceA == 5)
                        start1 = false;

                    else
                    {
                        Console.WriteLine("false choise");
                        break;
                    }

                }
            }
            else if (choiceAnimals == 3)
            {
                Console.WriteLine("You select Bird");
                Console.WriteLine("1 -- Play\n2 -- Sleep\n3 -- Eat\n4 -- show\n5 --exit\nyour choise: ");
                int.TryParse(Console.ReadLine(), out choiceA);

                while (start1 == true)
                {
                    if (choiceA == 1)
                    {
                        animals[2].Play();
                        animals[2].show();
                        break;
                    }
                    else if (choiceA == 2)
                    {
                        animals[2].Sleep();
                        break;
                    }
                    else if (choiceA == 3)
                    {
                        animals[2].Eat();
                        break;
                    }
                    else if (choiceA == 4)
                    {
                        animals[2].show();
                        break;
                    }
                    else if (choiceA == 5)
                        start1 = false;

                    else
                    {
                        Console.WriteLine("false choise");
                        break;
                    }

                }
            }
            else if (choiceAnimals == 4)
            {
                Console.WriteLine("You select Fish");
                Console.WriteLine("1 -- Play\n2 -- Sleep\n3 -- Eat\n4 -- show\n5 --exit\nyour choise: ");
                int.TryParse(Console.ReadLine(), out choiceA);

                while (start1 == true)
                {
                    if (choiceA == 1)
                    {
                        animals[3].Play();
                        animals[3].show();
                        break;
                    }
                    else if (choiceA == 2)
                    {
                        animals[3].Sleep();
                        break;
                    }
                    else if (choiceA == 3)
                    {
                        animals[3].Eat();
                        break;
                    }
                    else if (choiceA == 4)
                    {
                        animals[3].show();
                        break;
                    }
                    else if (choiceA == 5)
                        start1 = false;

                    else
                    {
                        Console.WriteLine("false choise");
                        break;
                    }

                }
            }
        }



    }
}