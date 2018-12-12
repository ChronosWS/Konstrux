using System.IO;
using System.Threading.Tasks;
using Konstrux.Api.Loaders.VoxelLoader;
using Xunit;

namespace API.Tests
{
  public class VoxelLoaderTests
    {
        [Fact]
        public async Task LoadDefaultVoxels()
        {
          var loader = new VoxelLoader();
          // TODO: Create a set of special test cases in the test directory for these
          var path = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\..\Mods\UrWorld\resources\voxels.yaml");
          await loader.LoadAsync(path);
          Assert.Contains("BareDirt", loader.Registry.Keys);
        }
    }
}
