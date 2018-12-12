// <copyright file="BiomeLoader.cs" company="Konstrux">
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

namespace Konstrux.Api.Loaders.BiomeLoader
{
  public class BiomeLoader : RegistryLoader<BiomeMeta>, IBiomeLoader
  {
    public const string ModMetaFileName = "biomes.yaml";
    public const string ModsRegistryName = "Biomes";

    public BiomeLoader() : base(ModsRegistryName) { }
    public static IBiomeLoader Instance { get; } = new BiomeLoader();
    public override Task LoadAsync(string path) => LoadMultipleAsync(path);
  }
}