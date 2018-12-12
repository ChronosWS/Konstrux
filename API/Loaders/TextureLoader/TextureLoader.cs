// <copyright file="TextureLoader.cs" company="Konstrux">
// Copyright (c) Konstrux. All rights reserved.
// Licensed under the "Creative Commons Attribution-ShareAlike 4.0 International Public License" license.
// See LICENSE file in the project root for full license information.
// </copyright>
// Author(s): Cliff Hudson

using System;
using System.IO;
using System.Threading.Tasks;
using Konstrux.Api.Registries;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace Konstrux.Api.Loaders.TextureLoader
{
  public class TextureLoader : RegistryLoader<TextureMeta>, ITextureLoader
  {
    public const string TexturesRegistryName = "Textures";

    public TextureLoader() : base(TexturesRegistryName) { }

    public override async Task LoadAsync(string path)
    {
      if (Directory.Exists(path))
      {
        foreach (var textureFile in Directory.EnumerateFiles(path))
        {
          var name = Path.GetFileNameWithoutExtension(textureFile);
          if (!this.Registry.TryGetValue(name, out var textureMeta))
          {
            textureMeta = new TextureMeta { Name = name };
            if (!this.Registry.TryAdd(name, textureMeta, out var _))
            {
              throw new Exception($"Failed to add texture {name} to registry");
            }
          }

          if (String.Equals(Path.GetExtension(textureFile), "yaml", StringComparison.OrdinalIgnoreCase))
          {
            textureMeta.Parameters = await this.LoadFromSingleFileAsync<TextureParameters>(textureFile);
          }
          else
          {
            textureMeta.Path = textureFile;
          }
        }
      }
    }
  }
}