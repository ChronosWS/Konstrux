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

namespace Konstrux.Api.ModLoader
{
  public class ModLoader : IModLoader
  {
    private const string ModMetaFileName = "modmeta.yaml";
    private const string ModsRegistryName = "Mods";

    public async Task LoadModsAsync(string path)
    {
      var yamlDeserializer = new DeserializerBuilder()
        .WithNamingConvention(new CamelCaseNamingConvention())
        .Build();

      if (Directory.Exists(path))
      {
        foreach (var modDirectory in Directory.EnumerateDirectories(path))
        {
          var modMetaPath = Path.Combine(modDirectory, ModMetaFileName);
          if (File.Exists(modMetaPath))
          {
            using (var file = File.OpenRead(modMetaPath))
            using (var textReader = new StreamReader(file))
            {
              var modYaml = await textReader.ReadToEndAsync();
              var modMeta = yamlDeserializer.Deserialize<ModMeta>(modYaml);
              if (!this.ModRegistry.TryAdd(modMeta.Id, modMeta, out var ignore))
              {
                throw new Exception($"Mod {modMeta.Id} already exists in the registry");
              }
            }
          }
        }
      }
    }

    public IRegistry<ModMeta> ModRegistry { get; } = Registry<ModMeta>.Create(ModsRegistryName);
  }
}