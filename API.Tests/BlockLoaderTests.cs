using System.IO;
using System.Threading.Tasks;
using Konstrux.Api.Loaders.BlockLoader;
using Xunit;

namespace API.Tests
{
  public class BlockLoaderTests
    {
        [Fact]
        public async Task LoadDefaultBlocks()
        {
          var loader = new BlockLoader();
          // TODO: Create a set of special test cases in the test directory for these
          var path = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\..\Mods\UrWorld\resources\blocks.yaml");
          await loader.LoadAsync(path);
          Assert.Contains("BareDirt", loader.Registry.Keys);
        }
    }
}
