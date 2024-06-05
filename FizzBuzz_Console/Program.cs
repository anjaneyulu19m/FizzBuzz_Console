using FizzBuzz_Console;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
services.Scan(s => s.FromAssemblyOf<Program>()
    .AddClasses(c => c.AssignableTo(typeof(IDivide)))
    .AsImplementedInterfaces()
    .WithScopedLifetime());

var serviceProvider = services.BuildServiceProvider();
using var scope = serviceProvider.CreateScope();
var divideCheck = scope.ServiceProvider.GetServices<IDivide>().ToList();

Console.WriteLine("Input Comma seperated test values");

string[]? input = Console.ReadLine()?.Split(',');
Console.WriteLine("\n");

// string[] input = new string[7] { "1", "3","", "5", "15","A", "23"};

if(input != null && input.Length > 0)
{
    for (int i = 0; i < input.Length; i++)
    {
        Result finalPrint = new Result();
        finalPrint.Messages = new Dictionary<int, string>();
        finalPrint.OperationMessages = new Dictionary<int, string>();
        int value = 0;
        if (Int32.TryParse(input[i], out value))
        {
            divideCheck.ForEach(e =>
            {
                DivideResult result = e.Validate(value);
                if (result.isDivisible)
                {
                    finalPrint.isDivisible = true;
                    if (result.Message != null)
                    {
                        finalPrint.Messages.Add(result.index, result.Message);
                    }
                }
                finalPrint.OperationMessages.Add(result.index, result.OperationMessage);
            });
            if (finalPrint.isDivisible)
            {
                finalPrint.Messages.OrderBy(i => i.Key);
                string mes = "";
                foreach (var item in finalPrint.Messages)
                {
                    mes += item.Value.ToString();
                }
                Console.WriteLine(mes);
            }
            else
            {
                finalPrint.OperationMessages.OrderBy(i => i.Key);
                string mes = "";
                foreach (var item in finalPrint.OperationMessages)
                {
                    mes += item.Value.ToString() + "\n";
                }
                Console.WriteLine(mes);

            }
        }
        else
        {
            Console.WriteLine("Invalid Item");
        }

    }
}



Console.ReadLine();

