using System;
using System.Threading.Tasks;

namespace RobloxUniversalScript
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Roblox Universal Script v1.0.0");
            Console.WriteLine("------------------------------");

            var script = new RobloxUniversalScript();
            var parser = new ScriptParser();

            string sampleScript = @"-- @name ExampleScript
local player = game.Players.LocalPlayer
print('Hello from universal script!')
return player.Name";

            try
            {
                var validatedScript = parser.ParseAndValidate(sampleScript);
                Console.WriteLine($"Script name: {parser.ExtractScriptName(validatedScript)}");
                Console.WriteLine("Executing script...");
                
                var result = await script.ExecuteScriptAsync(validatedScript);
                Console.WriteLine($"Result: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}