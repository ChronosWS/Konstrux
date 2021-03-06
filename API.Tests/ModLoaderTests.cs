using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Konstrux.Api.Loaders.ModLoader;
using Xunit;

namespace API.Tests
{
    public class ModLoaderTests
    {
        [Fact]
        public async Task LoadDefaultMods()
        {
          var loader = new ModLoader();
          // TODO: Create a set of special test cases in the test directory for these
          var modsPath = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\..\Mods");
          await loader.LoadAsync(modsPath);
          Assert.Contains("UrWorld", loader.Registry.Keys);
        }
    }
}
