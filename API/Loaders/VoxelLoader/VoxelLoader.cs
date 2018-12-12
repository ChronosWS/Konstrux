// <copyright file="VoxelLoader.cs" company="Konstrux">
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

namespace Konstrux.Api.Loaders.VoxelLoader
{
  public class VoxelLoader : RegistryLoader<VoxelMeta>, IVoxelLoader
  {
    public const string ModMetaFileName = "voxels.yaml";
    public const string ModsRegistryName = "Voxels";

    public VoxelLoader() : base(ModsRegistryName) { }
  }
}