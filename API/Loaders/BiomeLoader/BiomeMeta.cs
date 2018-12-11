// <copyright file="BiomeMeta.cs" company="Konstrux">
// Copyright (c) Konstrux. All rights reserved.
// Licensed under the "Creative Commons Attribution-ShareAlike 4.0 International Public License" license.
// See LICENSE file in the project root for full license information.
// </copyright>
// Author(s): Cliff Hudson

using System.Collections.Generic;

namespace Konstrux.Api.Loaders.BiomeLoader
{
  public class BiomeMeta
  {
    public string Name { get; set; }
    public string BlockTop { get; set; }
    public string BlockFill { get; set; }
    public float TreeDensity { get; set; }
    public List<BiomeTree> Trees { get; set; }
    public float VegitationDensity { get; set; }
    public List<BiomeVegetation> Vegetation { get; set; }
    public List<BiomeZone> Zones { get; set; }
    public List<BiomeOre> Ores { get; set; }

  }
}