using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Konstrux.Api.Loaders.WorldLoader;
using Xunit;

namespace API.Tests
{
    public class WorldLoaderTests
    {
        [Fact]
        public async Task LoadDefaultWorld()
        {
          var loader = new WorldLoader();
          // TODO: Create a set of special test cases in the test directory for these
          var path = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\..\Mods\UrWorld\resources\worlds.yaml");
          await loader.LoadAsync(path);
          Assert.Contains("Earth", loader.Registry.Keys);
        }
    }
}
