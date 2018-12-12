// <copyright file="RegistryLoader.cs" company="Konstrux">
// Copyright (c) Konstrux. All rights reserved.
// Licensed under the "Creative Commons Attribution-ShareAlike 4.0 International Public License" license.
// See LICENSE file in the project root for full license information.
// </copyright>
// Author(s): Cliff Hudson

using System;
using System.IO;
using System.Threading.Tasks;
using Konstrux.Api.Common;
using Konstrux.Api.Registries;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace Konstrux.Api.Loaders
{
  public class RegistryLoader<TData> : IRegistryLoader<TData> where TData : INamed
  {
    protected readonly IDeserializer yamlDeserializer = new DeserializerBuilder()
        .WithNamingConvention(new CamelCaseNamingConvention())
        .Build();

    public virtual Task LoadAsync(string path) => LoadFromYamlAsync(path);

    protected RegistryLoader(string name)
    {
      this.Registry = Registry<TData>.Create(name);
    }

    protected async Task LoadFromYamlAsync(string path)
    {
      if (File.Exists(path))
      {
        using (var file = File.OpenRead(path))
        using (var textReader = new StreamReader(file))
        {
          var yaml = await textReader.ReadToEndAsync();
          var metas = yamlDeserializer.Deserialize<TData[]>(yaml);
          foreach (var meta in metas)
          {
            if (!this.Registry.TryAdd(meta.Name, meta, out var ignore))
            {
              throw new Exception($"Mod {meta.Name} already exists in the registry");
            }
          }
        }
      }
    }

    protected async Task<TMeta> LoadFromSingleFileAsync<TMeta>(string path)
    {
      using (var file = File.OpenRead(path))
      using (var textReader = new StreamReader(file))
      {
        var yaml = await textReader.ReadToEndAsync();
        var meta = yamlDeserializer.Deserialize<TMeta>(yaml);
        return meta;
      }
    }

    public IRegistry<TData> Registry { get; }
  }
}