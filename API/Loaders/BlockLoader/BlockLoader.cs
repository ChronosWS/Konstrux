// <copyright file="BlockLoader.cs" company="Konstrux">
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

namespace Konstrux.Api.Loaders.BlockLoader
{
  public class BlockLoader : RegistryLoader<BlockMeta>, IBlockLoader
  {
    public const string ModMetaFileName = "blocks.yaml";
    public const string ModsRegistryName = "Blocks";

    public BlockLoader() : base(ModsRegistryName) { }
  }
}