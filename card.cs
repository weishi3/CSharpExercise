using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARPEXERCISE1
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("STARTING CARD COMPARING TESTING APP");
            Console.WriteLine("Do you want to add any user-defined card? (SAY \"yes\" OR \"no \" )   ") ;
            String firstChoice = Console.ReadLine();
            String newCardName;
            int newValue;
            Dictionary<string, int> myNewCard = new Dictionary<string,int>();
            while (firstChoice == "yes") {
                Console.WriteLine("Now enter the name of your new card: ");
                newCardName = Console.ReadLine();
                Console.WriteLine("Now enter the value of your new card: (NORMAL CARDS's values varies from 3 to 17) ");
                newValue =  int.Parse(Console.ReadLine());
                myNewCard.Add(newCardName, newValue);

                Console.WriteLine("Success! DO YOU WANT TO ADD MORE?");
                firstChoice = Console.ReadLine();
            }
            
            int firstValue=-1;
            int secondValue=-1;

            while (true)
            {
                Console.WriteLine("PRESS ANYTHING TO SRART COMPARING: or Press Q to quit");
                string temp = Console.ReadLine();
                if (temp == "Q" || temp == "q") break;

                Console.WriteLine("Enter first card: (you may use self-defined name or something like \"Ace\",\" Two\", \"BlackJoker\" or \"Prince\") ");
                string firstCard = Console.ReadLine();
                firstValue = identifyCard(firstCard, myNewCard);
                Console.WriteLine("Enter the second card");
                string secondCard = Console.ReadLine();
                secondValue = identifyCard(secondCard, myNewCard);
                string useToOutput = "";
                if (firstValue == secondValue)
                {
                    useToOutput = " has the same weight as ";
                }
                else if (firstValue > secondValue)
                {
                    useToOutput = " is greater than ";
                }
                else
                {
                    useToOutput = " is smaller than ";
                }
                Console.WriteLine(firstCard + useToOutput + secondCard);
                Console.ReadLine();
            }


        }

        static int identifyCard(string firstCard, Dictionary<string,int>myNewCard){
            Card defaultValue;
            while ((!myNewCard.ContainsKey(firstCard)) && ( !(Enum.TryParse<Card>(firstCard,true, out defaultValue) )  ) ){
                Console.WriteLine("INVALID CARD, TRY ANOTHER!");
                firstCard=Console.ReadLine();
            }
            if (myNewCard.ContainsKey(firstCard)){
                return myNewCard[firstCard];
            }else{
                Enum.TryParse<Card>(firstCard,true, out defaultValue);
                return getValue(defaultValue);
            }
        }
        static int getValue(Card c){
            switch (c){
                case Card.ACE:
                    return 14;
                case Card.TWO:
                    return 15;
                case Card.THREE:
                    return 3;
                case Card.FOUR:
                    return 4;
                case Card.FIVE:
                    return 5;
                case Card.SIX:
                    return 6;
                case Card.SEVEN:
                    return 7;
                case Card.EIGHT:
                    return 8;
                case Card.NINE:
                    return 9;
                case Card.TEN:
                    return 10;
                case Card.QUEEN:
                    return 12;
                case Card.KING:
                    return 13;
                case Card.BLACKJOKER:
                    return 16;
                case Card.REDJOKER:
                    return 17;
                case Card.PRINCE:
                    return 11;
                default:
                    return -1;

            
            }
        }

        
    }
    enum Card{
        ACE,TWO,THREE,FOUR,FIVE,SIX,SEVEN,EIGHT,NINE,TEN,PRINCE,QUEEN,KING,REDJOKER,BLACKJOKER
    }




    
}
