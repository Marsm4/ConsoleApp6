//string prompt = Console.ReadLine();
//Coffee coffee_client = null;
//if (prompt != null)
//    coffee_client = CoffeeShop.OrderCoffee(prompt);

//Americano coffee = coffee_client as Americano;
//Console.WriteLine();

//public class Coffee
//{
//    public void grindCoffee()
//    {
//        // перемалываем кофе
//    }
//    public void makeCoffee()
//    {
//        // делаем кофе
//    }
//    public void pourIntoCup()
//    {
//        // наливаем в чашку
//    }
//}
//public class Americano : Coffee { }
//public class Cappuccino : Coffee { }
//public class CaffeLatte : Coffee { }
//public class Espresso : Coffee { }

//public static class CoffeeShop
//{
//    public static Coffee OrderCoffee(string type)
//    {
//        Coffee coffee = null;

//        switch (type)
//        {
//            case "AMERICANO":
//                coffee = new Americano();
//                break;
//            case "ESPRESSO":
//                coffee = new Espresso();
//                break;
//            case "CAPPUCCINO":
//                coffee = new Cappuccino();
//                break;
//            case "CAFFE_LATTE":
//                coffee = new CaffeLatte();
//                break;
//        }


//        Console.WriteLine($"Вот ваш кофе {coffee.GetType()}! Спасибо, приходите еще!");
//        return coffee;
//    }
//}

string prompt = Console.ReadLine();
Tie Tie_client = null;
if (prompt != null)
    Tie_client = TieShop.OrderTie(prompt);

EarlGrey Tie = Tie_client as EarlGrey;
Console.WriteLine();

public class Tie
{
    public void brewTie()
    {
        
    }
 
    public void pourIntoTie()
    {
       
    }

    public void drinkTie()
    {
        
    }
}
public class EarlGrey : Tie { }
public class Oolong : Tie { }
public class Match : Tie { }
public class Anchan : Tie { }

public class White : Tie { }

public static class TieShop
{
    public static Tie OrderTie(string type)
    {
        Tie Tie = null;

        switch (type)
        {
            case "EarlGrey":
                Tie = new EarlGrey();
                break;
            case "Oolong":
                Tie = new Oolong();
                break;
            case "Match":
                Tie = new Match();
                break;
            case "Anchan":
                Tie = new Anchan();
                break;
            case "White":
                Tie = new White();
                break;
        }


        Console.WriteLine($"Вот ваш чай {Tie.GetType()}! Спасибо, приходите еще!");
        return Tie;
    }
}



