using CommandLine;

namespace Dangl.Oenorm.Examples
{
    public class Options
    {
        [Option('i', "input", Required = true, HelpText = "Relative or absolute path to a GAEB file")]
        public string InputFilePath { get; set; }

        [Option('o', "output", Required = true, HelpText = "Relative or absolute path to the output ÖNorm file")]
        public string OutputFilePath { get; set; }
    }
}
