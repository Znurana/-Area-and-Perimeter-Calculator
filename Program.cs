namespace AreaAndPerimeterCalculations;


class Program
{

    static void Main(string[] args)
    {
        ShowMenu();
    }

    public static void ShowMenu()
    {
        int menu = 0;
      
        do
        {
            MainMenuList();
            Console.WriteLine("Seçiminizi daxil edin:");
            menu = int.Parse(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    CalculateArea();
                    break;
                case 2:
                    CalculatePerimeter();
                    break;
                case 3:
                    Exit();
                    break;
                default:
                    Console.WriteLine("Yanlış seçim. Yenidən cəhd edin");

                    break;
            }
        } while (menu != 3);
    }

    public static void MainMenuList()
    {
        Console.WriteLine("---------------------");
        Console.WriteLine("ƏSAS MENYU");
        Console.WriteLine("1.Sahənin hesablanması");
        Console.WriteLine("2.Perimetr hesablanması");
        Console.WriteLine("3.Çıxış");
        Console.WriteLine("---------------------");
    }




    public static void ShowSubMenu()
    {
        Console.WriteLine("---------------------");
        Console.WriteLine("FİQUR SEÇİMİ ALT MENU");
        Console.WriteLine("1.Kvadrat");
        Console.WriteLine("2.Düzbucaqlı");
        Console.WriteLine("3.Üçbucaq");
        Console.WriteLine("4.Çevrə");
        Console.WriteLine("5.Əsas Menyu");
        Console.WriteLine("---------------------");
    }

    public static void Exit()
    {
        Console.WriteLine("Proqramdan çıxmaq istədiyinizə əminsiniz?(B/X)");
        string exit = Console.ReadLine().ToLower();
        if (exit == "b")
        {
            Console.WriteLine("Proqramdan çıxdınız");
            return;
        }
        else if (exit == "x")
        {
            ShowMenu();
        }
        else
        {
            Console.WriteLine("Yalnış daxil etdiniz. 'H' və ya 'Y' daxil edin.");
            ShowMenu();
        }
    }

    public static void CalculateArea()
    {
        int figure;
        ShowSubMenu();
        do
        {
            Console.WriteLine("Fiqur seçin:");
           figure = int.Parse(Console.ReadLine());
            SwitchArea(figure);
        } while (figure != 5);
    }

    public static void SwitchArea(int figure)
    {
        int Area, a, b, h, r,length,wide;


        float pi = 3.14f;
        switch (figure)
        {
            case 1:
                Console.WriteLine($"{Figures.Kvadrat}: bir tərəfi daxil edin");
                 a = int.Parse(Console.ReadLine());
                Area = a * a;
                Console.WriteLine($"Area = {Area}");
                RecalculateArea(figure);
                break;
            case 2:
                Console.WriteLine($"{Figures.Düzbucaqlı}: uzunluq daxil edin ");
                length = int.Parse(Console.ReadLine());
                Console.WriteLine("En daxil edin ");
                wide = int.Parse(Console.ReadLine());
                Area = length * wide;
                Console.WriteLine($"Sahe = {Area}");
                RecalculateArea(figure);
                break;
            case 3:
                Console.WriteLine($"{Figures.Üçbucaq} : bərabəryanlı üçbucağın bir tərəfini daxil edin");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Bərabəryanlı üçbucağın digər(oturacaq)tərəfini daxil edin");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("Bərabəryanlı üçbucağın hündürlüyünü daxil edin");
                h = int.Parse(Console.ReadLine());
                Area = 1 / 2 * b * h;
                Console.WriteLine($"Sahe = {Area}");
                RecalculateArea(figure);
                break;
            case 4:
                Console.WriteLine("Dairənin Radiusun daxil edin");
                r = int.Parse(Console.ReadLine());
                float CycleArea = pi * r * r;
                Console.WriteLine($"Sahə = {CycleArea}");
                RecalculateArea(figure);
                break;
            case 5:
                ShowMenu();
                break;
            default:
                Console.WriteLine("Yanlış seçim.");
                break;
        }
    }
    public static void RecalculateArea(int figure)
    {
        string answer;
        Console.WriteLine("Eyni forma növü üçün yenidən sahə hesablamaq istəyirsinizmi?(B/X)");
        answer = Console.ReadLine().ToLower();
        if (answer == "b")
        {
            SwitchArea(figure);
        }
        else if (answer == "x")
        {
            CalculateArea();
        }
        else
        {
            Console.WriteLine("Yalnış seçim");
        }
    }

    public static void CalculatePerimeter()
    {
        ShowSubMenu();
        int figure;
        do
        {
            Console.WriteLine("Fiqur seçin:");
            figure = int.Parse(Console.ReadLine());
            SwitchPerimetr(figure);
        } while (figure != 5);

    }
    public static void SwitchPerimetr(int figure)
    {
       int Perimetr, a, b, h, r,length,wide ;
        float pi = 3.14f;
        switch (figure)
        {
            case 1:
                Console.WriteLine($"{Figures.Kvadrat} : bir tərəfini daxil edin");
                 a = int.Parse(Console.ReadLine());
                Perimetr = 4 * a;
                Console.WriteLine($"Perimetr = {Perimetr}");
                RecalculatePerimetr(figure);
                break;
            case 2:
                Console.WriteLine($"{Figures.Düzbucaqlı}: Uzunluğunu daxil edin ");
                length = int.Parse(Console.ReadLine());
                Console.WriteLine("En daxil edin ");
                wide = int.Parse(Console.ReadLine());
                Perimetr = 2 * (length + wide);
                Console.WriteLine($"Perimetr = {Perimetr}");
                RecalculatePerimetr(figure);
                break;
            case 3:
                Console.WriteLine($"{Figures.Üçbucaq} : Bərabəryanlı üçbucağın bir tərəfini daxil edin");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Bərabəryanlı üçbucağın digər(oturacaq)tərəfini daxil edin");
                b = int.Parse(Console.ReadLine());
                Perimetr = b + (2 * a);
                Console.WriteLine($"Perimetr = {Perimetr}");
                RecalculatePerimetr(figure);
                break;
            case 4:
                Console.WriteLine($"{Figures.Çevrə}  :Radiusun daxil edin");
                r = int.Parse(Console.ReadLine());
                float CyclePerimetr = 2 * pi * r;
                Console.WriteLine($"Perimetr = {CyclePerimetr}");
                RecalculatePerimetr(figure);
                break;
            case 5:
                ShowMenu();
                break;
            default:
                Console.WriteLine("Yanlış seçim. Yenidən cəhd edin");
                break;
        }
    }

    public static void RecalculatePerimetr(int figure)
    {
        string answer;
        Console.WriteLine("Eyni forma növü üçün yenidən perimetri hesablamaq istəyirsinizmi?(B/X)");
        answer = Console.ReadLine().ToLower();
        if (answer == "b")
        {
            SwitchPerimetr(figure);
        }
        else if(answer=="x")
        {
            CalculatePerimeter();
        }
        else
        {
            Console.WriteLine("Yalnış seçim");
        }
    }


   

}





