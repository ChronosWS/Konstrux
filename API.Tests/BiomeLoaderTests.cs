using System.IO;
using System.Threading.Tasks;
using Konstrux.Api.Loaders.BiomeLoader;
using Xunit;

namespace API.Tests
{
  public class BiomeLoaderTests
    {
        [Fact]
        public async Task LoadDefaultBiomes()
        {
          var loader = new BiomeLoader();
          // TODO: Create a set of special test cases in the test directory for these
          var path = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\..\Mods\UrWorld\resources\biomes.yaml");
          await loader.LoadAsync(path);
          Assert.Contains("Bare", loader.Registry.Keys);
        }
    }
}
