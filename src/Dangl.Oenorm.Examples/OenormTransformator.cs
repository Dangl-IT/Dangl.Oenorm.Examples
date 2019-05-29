using Dangl.AVA;
using System.IO;
using System.Threading.Tasks;

namespace Dangl.Oenorm.Examples
{
    public class OenormTransformator
    {
        private readonly Options _options;

        public OenormTransformator(Options options)
        {
            _options = options;
        }

        private Project _readProject;

        public async Task TransformGaebAsync()
        {
            ReadInputGaebFile();
            await TransformToOenormAsync();
        }

        private void ReadInputGaebFile()
        {
            var filePath = Path.GetFullPath(_options.InputFilePath);
            using (var fileStream = File.OpenRead(filePath))
            {
                var gaebFile = Dangl.GAEB.Reader.GAEBReader.ReadGaeb(fileStream);
                _readProject = Dangl.AVA.Converter.Converter.ConvertFromGaeb(gaebFile);
            }
        }

        private async Task TransformToOenormAsync()
        {
            var convertedProject = Dangl.Oenorm.Converter.ConvertToOenorm(_readProject, OenormDestinationType.LV2015);
            using (var oenormStream = Dangl.Oenorm.Writer.OenormWriter.GetStream(convertedProject))
            {
                var outputPath = Path.GetFullPath(_options.OutputFilePath);
                using (var fileStream = File.Create(outputPath))
                {
                    await oenormStream.CopyToAsync(fileStream);
                }
            }
        }
    }
}
