// Program.cs

using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Threading.Tasks;

namespace LabChatApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.Write("Enter your name: ");
            var userName = Console.ReadLine();

            var connection = new HubConnectionBuilder()
                .WithUrl("http://localhost:5000/chathub") // Replace with your server URL
                .Build();

            connection.On<string, string>("ReceiveMessage", (user, message) =>
            {
                Console.WriteLine($"{user}: {message}");
            });

            try
            {
                await connection.StartAsync();
                Console.WriteLine("Connected to chat. Start typing messages...");

                while (true)
                {
                    var message = Console.ReadLine();
                    await connection.InvokeAsync("SendMessage", userName, message);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error connecting: {ex.Message}");
            }
        }
    }
}
