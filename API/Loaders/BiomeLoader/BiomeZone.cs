// <copyright file="BiomeZone.cs" company="Konstrux">
// Copyright (c) Konstrux. All rights reserved.
// Licensed under the "Creative Commons Attribution-ShareAlike 4.0 International Public License" license.
// See LICENSE file in the project root for full license information.
// </copyright>
// Author(s): Cliff Hudson

using System.Collections.Generic;

namespace Konstrux.Api.Loaders.BiomeLoader
{
  public class BiomeZone
  {
    public float ElevationMin { get; set; }
    public float ElevationMax { get; set; }
    public float MoistureMin { get; set; }
    public float MoistureMax { get; set; }    
  }
}