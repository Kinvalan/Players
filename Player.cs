using System;

public class Player
{
    public string Name { get; private set; }
    public int Points { get; private set; }

    
    public Player(string name, int points)
    {
        Name = name;
        Points = points;
    }

    /*
    Metoden Play() skal inneholde en måte å velge en tilfeldig vinner og taper av de som blir trukket. 
    Vinneren skal få 1 poeng, taperen mister 1 poeng. Til slutt vises det hvor mange poeng hver av dem har.  
    */
    public void Play(Player opponent)
    { 
        var random = new Random();

        double randomOutcome = random.NextDouble();


        if(randomOutcome < 0.5)
        {
            // Den nåværende spilleren vinner
            Points += 1;
            opponent.Points -= 1;
            Console.WriteLine($"{Name} vant mot {opponent.Name}.\n");
        }

        else if (randomOutcome > 0.5)
        {
            // Motstanderen vinner
            Points -= 1;
            opponent.Points += 1;
            Console.WriteLine($"{opponent.Name} vant mot {Name}.\n");
        }

    }

    public void ShowNameAndPoints()
    {
         Console.WriteLine($"{Name} har {Points} poeng.");
    }
    
}
