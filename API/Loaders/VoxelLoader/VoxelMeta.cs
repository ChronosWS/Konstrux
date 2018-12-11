// <copyright file="VoxelMeta.cs" company="Konstrux">
// Copyright (c) Konstrux. All rights reserved.
// Licensed under the "Creative Commons Attribution-ShareAlike 4.0 International Public License" license.
// See LICENSE file in the project root for full license information.
// </copyright>
// Author(s): Cliff Hudson

using System.Collections.Generic;

namespace Konstrux.Api.Loaders.VoxelLoader
{
  public class VoxelMeta
  {
    public string Name { get; set; }
    public VoxelTextures Textures { get; set; }
    public float ColorVariation { get; set; }
    public string TintColor { get; set; }
  }
}