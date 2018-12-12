// <copyright file="WorldLoader.cs" company="Konstrux">
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

namespace Konstrux.Api.Loaders.WorldLoader
{
  public class WorldLoader : RegistryLoader<WorldMeta>, IWorldLoader
  {
    public const string ModMetaFileName = "worlds.yaml";
    public const string ModsRegistryName = "Worlds";

    public WorldLoader() : base(ModsRegistryName) { }
    public static IWorldLoader Instance { get; } = new WorldLoader();
    public override Task LoadAsync(string path) => LoadMultipleAsync(path);
  }
}