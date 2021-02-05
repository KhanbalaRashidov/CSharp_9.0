using System;
using System.Threading;
using Telegram.Bot;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
namespace Telegram_bot_lib
{
    class Program
    {
        static TelegramBotClient botClient;
        static void Main(string[] args)
        {
            botClient = new TelegramBotClient("1521118734:AAFJ6Niq4lsqFYeCDVD877kflAT_yz7iqTY");

            botClient.OnMessage += Bot_OnMEssage;
            botClient.StartReceiving();
            Thread.Sleep(100);
            Console.ReadLine();

        }

        static async void Bot_OnMEssage(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {
            if (e.Message.Text != null)
            {
                Console.WriteLine($"Message in chat {e.Message.Chat} and chat id: {e.Message.Chat.Id}");

                await botClient.SendTextMessageAsync(
                    chatId: e.Message.Chat,
                    text: "Botuma xoş gəlmisiniz | Welcome my Bots"
                    );

                if (e.Message.Text.ToUpper() == "SALAM")
                {
                    await botClient.SendTextMessageAsync(
                       chatId: e.Message.Chat,
                       text: $"Salam {e.Message.Chat.Username} "
                       );
                }
                else if (e.Message.Text.ToUpper() == "HELLO" || e.Message.Text.ToLower() == "hi")
                {
                    await botClient.SendTextMessageAsync(
                        chatId: e.Message.Chat,
                        text: $"Hello {e.Message.Chat.Username}");
                }


                await botClient.SendAudioAsync(
                    chatId: e.Message.Chat,
                    audio: "https://github.com/TelegramBots/book/raw/master/src/docs/audio-guitar.mp3"
                    );


            }



        }
    }
}
