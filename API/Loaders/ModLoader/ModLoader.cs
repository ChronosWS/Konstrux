// <copyright file="ModLoader.cs" company="Konstrux">
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

namespace Konstrux.Api.Loaders.ModLoader
{
  public class ModLoader : RegistryLoader<ModMeta>, IModLoader
  {
    public const string ModMetaFileName = "modmeta.yaml";
    public const string ModsRegistryName = "Mods";

    public ModLoader() : base(ModsRegistryName) { }

    public override async Task LoadAsync(string path)
    {
      if (Directory.Exists(path))
      {
        foreach (var modDirectory in Directory.EnumerateDirectories(path))
        {
          var modMetaPath = Path.Combine(modDirectory, ModMetaFileName);
          if (File.Exists(modMetaPath))
          {
            await base.LoadFromYamlAsync(modMetaPath);
          }
        }
      }
    }
  }
}