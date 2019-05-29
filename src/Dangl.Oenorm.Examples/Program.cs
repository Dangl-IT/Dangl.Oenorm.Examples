using CommandLine.Text;
using System;
using System.Threading.Tasks;

namespace Dangl.Oenorm.Examples
{
    class Program
    {
        private static void Main(string[] args)
        {
            var optionsParser = new OptionsParser(args);
            if (optionsParser.IsValid)
            {
                Console.WriteLine(HeadingInfo.Default);
                Console.WriteLine(CopyrightInfo.Default);
                try
                {
                    TransformGaebToOenormAsync(optionsParser.Result)
						.ConfigureAwait(false)
						.GetAwaiter()
						.GetResult();
                    Console.WriteLine("Finished GAEB to ÖNorm transformation");
                }
                catch (Exception e)
                {
                    DisplayExceptionDetails(e);
                }
            }
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        private static void DisplayExceptionDetails(Exception e)
        {
            Console.Write(e.ToString());
            Console.WriteLine();
        }

        private static async Task TransformGaebToOenormAsync(Options options)
        {
            var transformator = new OenormTransformator(options);
            await transformator.TransformGaebAsync();
        }
    }
}
