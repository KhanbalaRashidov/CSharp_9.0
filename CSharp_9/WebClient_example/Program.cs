using System;
using System.Net;
using System.IO;
using System.Text;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.Threading;

namespace WebClient_example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome telegram bot\n");
            // https://telegram.org/
            // https://core.telegram.org/api
            // https://core.telegram.org/bots
            // https://core.telegram.org/bots/samples How do I create a bot?
            // https://core.telegram.org/bots/api How do bots work?

            // http://t.me/BotFather
            // @BotFather
            
            var token =File.ReadAllText(@"C:\Telegram_Bot\Token\token.txt");
            Console.WriteLine(token);

            WebClient webClient = new() { Encoding = Encoding.UTF8 };

            string startUrl = $@"https://api.telegram.org/bot{token}/";
            int update_id = 0;
            while (true)
            {
                string url = $"{startUrl}getUpdates?offset={update_id}";
                var r = webClient.DownloadString(url);

               
                //Console.ReadLine();
               
                var messages = JObject.Parse(r)["result"].ToArray();
                
                foreach (dynamic msg in messages)
                {
                    update_id = Convert.ToInt32(msg.update_id) + 1;

                    string userMessage = msg.message.text;
                    string userId = msg.message.from.id;
                    string userFirstName = msg.message.from.first_name;

                    string text = $"{userFirstName} {userId} {userMessage}";

                    Console.WriteLine(text);

                    if (userMessage=="salam"||userMessage=="Salam"||userMessage=="Salaam"||userMessage=="salamm")
                    {
                        string responseText =$"Salam {userFirstName} Necəsən?";
                        url = $"{startUrl}sendMessage?chat_id={userId}&text={responseText}";
                        
                        Console.WriteLine(webClient.DownloadString(url));
                    }
                    else if (userMessage=="hello"||userMessage=="Hello"||userMessage=="hi"||userMessage=="Hi"||userMessage=="helloo")
                    {
                        string responseText = $"Hello {userFirstName} How are You?";
                        url = $"{startUrl}sendMessage?chat_id={userId}&text={responseText}";

                        Console.WriteLine(webClient.DownloadString(url));
                    }
                   else if (userMessage=="Yaxşı sən?"||userMessage== "Yaxşı sən"||userMessage=="Yaxshi sen?")
                    {
                        string responseText = $" Yaxşıyam";
                        url = $"{startUrl}sendMessage?chat_id={userId}&text={responseText}";
                        Console.WriteLine(webClient.DownloadString(url));
                    }
                    else if (userMessage=="I'm fine are you"||userMessage=="I'm fine are you?"||userMessage=="I'm good")
                    {
                        string responseText = $"I'm good";
                        url = $"{startUrl}sendMessage?chat_id={userId}&text={responseText}";
                        Console.WriteLine(webClient.DownloadString(url));
                    }
                }
                Thread.Sleep(100);

            }
            Console.WriteLine("++++");

             

        }
    }
}
