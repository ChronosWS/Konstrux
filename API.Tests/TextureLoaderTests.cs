using System.IO;
using System.Threading.Tasks;
using Konstrux.Api.Loaders.TextureLoader;
using Xunit;

namespace API.Tests
{
  public class TextureLoaderTests
    {
        [Fact]
        public async Task LoadDefaultTextures()
        {
          var loader = new TextureLoader();
          // TODO: Create a set of special test cases in the test directory for these
          var path = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\..\Mods\UrWorld\resources\textures");
          await loader.LoadAsync(path);
          Assert.Contains("bare_dirt", loader.Registry.Keys);
        }
    }
}
