// See https://aka.ms/new-console-template for more information
Console.WriteLine("Вы просыпаетесь в незнакомой комнате и пытаетесь вспомнить свое имя");
Console.WriteLine("Введите имя");
String name = Console.ReadLine();
bool отмычка = false;
bool artefactBed = false;
bool artefactVent = false;
bool artefactTumbochka = false;
bool boxKey = false;
int VentForce = 0;

while (true)
{
    Console.WriteLine("Вы изучаете команту вокруг себя");
    Console.WriteLine("Что вы хотите сделать?");
    Console.WriteLine("a: осмотреть дверь");
    Console.WriteLine("b: осмотреть кровать");
    Console.WriteLine("c: осмотреть ящик в углу комнаты");
    Console.WriteLine("d: осмотреть вентиляцию");
    Console.WriteLine("e: осмотреть тумбочку");
    Console.WriteLine("f: осмотреть статую рядом с дверью");
    String iunput = Console.ReadLine();
    if (iunput == "a")
    {
        if (отмычка == false)
        {
            Console.WriteLine("Дверь заперта");
        }
        else
        {
            Console.WriteLine("Вы выбрались!");
            break;

        }
    }
    else if (iunput == "b")
    {
        if (artefactBed == true)
        {
            Console.WriteLine("Вы здесь уже все нашли");
        }
        else
        {
            Console.WriteLine("Вы заглянули под кровать и нашли артефакт!");
            artefactBed = true;

        }

    }

    else if (iunput == "c")
    {

        if (отмычка == true)
        {
            Console.WriteLine("Вы здесь уже все нашли");
        }
        else
        {
            if (boxKey == false)
            {
                Console.WriteLine("Ящик закрыт");
            }
            else
            {
                Console.WriteLine("Ключ подошел! вы открыли ящик и нашли отмычку");
                отмычка = true;

            }
        }
    }
    else if (iunput == "d")
    {
        if (artefactVent == true)
        {
            Console.WriteLine("Вы здесь уже все нашли");
        }
        else { 
        if (VentForce < 3)
        {
            Console.WriteLine(" Вентияция не открываетмся, возможно надо попробовать еще раз");
            VentForce = VentForce + 1;
        }
        else
        {
            Console.WriteLine("Вы открыли вентиляцию и нашли артефакт!");
            artefactVent = true;

        }
        }
    }
    else if (iunput == "e")
    {

        if (artefactTumbochka == true)
        {
            Console.WriteLine("Вы здесь уже все нашли");
        }
        else
        {
            Console.WriteLine("Вы осмотрели тумбочку и нашли артефакт!");
            artefactTumbochka = true;

        }
    }
    else if (iunput == "f")
    {
        if (boxKey == true)
        {
            Console.WriteLine("Вы здесь уже все нашли");
        }
        else
        {
            if (artefactTumbochka == true && artefactBed == true && artefactVent == true)
            {
                Console.WriteLine("Вы вставили все артефакты в статую и получили ключ");
                boxKey = true;
            }
            else
            {
                Console.WriteLine("Здесь есть место для трех атефактов... где бы они могли быть?");


            }
        }
    }
    else
    {
        Console.WriteLine("Больше осматривать нечего");
    }
}
Console.WriteLine($"Ваше приключение продолжается! Встретимя с будущем, {name}");
Console.WriteLine("Продолжение следует...");

Console.ReadLine();