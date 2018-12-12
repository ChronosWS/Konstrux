// <copyright file="ModLoader.cs" company="Konstrux">
// Copyright (c) Konstrux. All rights reserved.
// Licensed under the "Creative Commons Attribution-ShareAlike 4.0 International Public License" license.
// See LICENSE file in the project root for full license information.
// </copyright>
// Author(s): Cliff Hudson

using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Konstrux.Api.Registries;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace Konstrux.Api.Loaders.ModLoader
{
  public class ModLoader : RegistryLoader<ModMeta>, IModLoader
  {
    public const string ModMetaFileName = "modmeta.yaml";
    public const string ModsRegistryName = "Mods";
    public const string ResourcesDirectory = "resources";

    public ModLoader() : base(ModsRegistryName) { }

    public static IModLoader Instance { get; } = new ModLoader();

    public override async Task LoadAsync(string path)
    {
      if (Directory.Exists(path))
      {
        // Load the top level mod metadata
        foreach (var modDirectory in Directory.EnumerateDirectories(path))
        {
          var modMetaPath = Path.Combine(modDirectory, ModMetaFileName);
          if (File.Exists(modMetaPath))
          {
            await base.LoadAsync(modMetaPath);
          }
        }

        // TODO: Evaluate and resolve dependency requirements

        // Load the resource metadata for each mod
        foreach(var mod in (IEnumerable<ModMeta>)this.Registry) {
          await TextureLoader.TextureLoader.Instance.LoadAsync(Path.Combine(path, mod.Name, ResourcesDirectory, TextureLoader.TextureLoader.ModMetaDirectory));
          await VoxelLoader.VoxelLoader.Instance.LoadAsync(Path.Combine(path, mod.Name, ResourcesDirectory, VoxelLoader.VoxelLoader.ModMetaFileName));
          await BlockLoader.BlockLoader.Instance.LoadAsync(Path.Combine(path, mod.Name, ResourcesDirectory, BlockLoader.BlockLoader.ModMetaFileName));
          await BiomeLoader.BiomeLoader.Instance.LoadAsync(Path.Combine(path, mod.Name, ResourcesDirectory, BiomeLoader.BiomeLoader.ModMetaFileName));
          await WorldLoader.WorldLoader.Instance.LoadAsync(Path.Combine(path, mod.Name, ResourcesDirectory, WorldLoader.WorldLoader.ModMetaFileName));
        }
      }
    }
  }
}