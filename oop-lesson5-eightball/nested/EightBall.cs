using System;
using System.Collections;
namespace oop_lesson5_eightball.nested
{
    public class EightBall
    {
        private static int randomNumber() //Private to be used just for the EightBall Class/Method
        {
            Random random = new Random();
            int randomNumber =  random.Next(20);
            return randomNumber;
        }

        public static void messagesEightBall()
        {
            ArrayList messages = new ArrayList();
            messages.Add("It is certain");
            messages.Add("It is decidedly so.");
            messages.Add("Without a doubt.");
            messages.Add("Yes definitely.");
            messages.Add("You may rely on it.");
            messages.Add("As I see it, yes.");
            messages.Add("Most likely.");
            messages.Add("Outlook good.");
            messages.Add("Yes.");
            messages.Add("Signs point to yes.");
            messages.Add("Reply hazy, try again.");
            messages.Add("Ask again later.");
            messages.Add("Better not tell you now.");
            messages.Add("Cannot predict now.");
            messages.Add("Concentrate and ask again.");
            messages.Add("Don't count on it.");
            messages.Add("My reply is no.");
            messages.Add("My sources say no.");
            messages.Add("Outlook not so good.");
            messages.Add("Very doubtful.");

            Console.WriteLine(messages[EightBall.randomNumber()]);

        }
    }

}
