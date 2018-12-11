// <copyright file="WorldMeta.cs" company="Konstrux">
// Copyright (c) Konstrux. All rights reserved.
// Licensed under the "Creative Commons Attribution-ShareAlike 4.0 International Public License" license.
// See LICENSE file in the project root for full license information.
// </copyright>
// Author(s): Cliff Hudson

using System.Collections.Generic;

namespace Konstrux.Api.Loaders.WorldLoader
{
  public class WorldMeta
  {
    public string Name { get; set; }
    public List<string> Biomes { get; set; }
    public string BedrockBlock { get; set; }
    public WorldSky Sky { get; set; }
    public string TerrainGenerator { get; set; }
    public List<string> DetailGenerators { get; set; }
    public float Gravity { get; set; }
  }
}