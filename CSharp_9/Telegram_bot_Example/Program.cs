using System;
using System.IO;
using System.Net;
using System.Net.Http;
using Telegram.Bot;
using Telegram.Bot.Args;



namespace Telegram_bot_Example
{

    class Program
    {
        static TelegramBotClient bot;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string token = System.IO.File.ReadAllText(@"C:\Telegram_Bot\Token\token.txt");
            Console.WriteLine(token);
            #region Proxy
            
            var proxy = new WebProxy()
            {
                Address = new Uri($"http://77.87.240.74:3128"),
                UseDefaultCredentials = false,
            //    Credentials = new NetworkCredential(userName: username, password: password)
            };

            var httpClientGandler = new HttpClientHandler() { Proxy=proxy};

            HttpClient httpClient = new HttpClient(httpClientGandler);
            bot = new TelegramBotClient(token, httpClient);
            #endregion
            //   bot = new TelegramBotClient(token);
            bot.OnMessage += Bot_OnMessage;
            bot.StartReceiving();
            Console.ReadKey();

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void Bot_OnMessage(object sender, MessageEventArgs e)
        {
            string text = $"{DateTime.Now.ToLongTimeString()} {e.Message.Chat.FirstName} {e.Message.Chat.Id} {e.Message.Text}";
            Console.WriteLine(text);

            Console.WriteLine($"{text} TypeMessage:{e.Message.Type.ToString()}");

            if (e.Message.Type == Telegram.Bot.Types.Enums.MessageType.Document)
            {
                Console.WriteLine(e.Message.Document.FileId);
                Console.WriteLine(e.Message.Document.FileName);
                Console.WriteLine(e.Message.Document.FileSize);

                Download(e.Message.Document.FileId,e.Message.Document.FileName);
            }
            if (e.Message.Text == null) return;

            bot.SendTextMessageAsync(
                e.Message.Chat.Id,
                $"Hello {e.Message.Chat.Username} "+e.Message.Text);
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="path"></param>
        private static async void Download(string fileId, string path)
        {
            var file = await bot.GetFileAsync(fileId);
            var fs = new FileStream("_" + path, FileMode.Create);
            await bot.DownloadFileAsync(file.FilePath, fs);
            fs.Close();
            fs.Dispose();
        }
    }
}
