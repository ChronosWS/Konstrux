// <copyright file="BiomeOre.cs" company="Konstrux">
// Copyright (c) Konstrux. All rights reserved.
// Licensed under the "Creative Commons Attribution-ShareAlike 4.0 International Public License" license.
// See LICENSE file in the project root for full license information.
// </copyright>
// Author(s): Cliff Hudson

using System.Collections.Generic;

namespace Konstrux.Api.Loaders.BiomeLoader
{
  public class BiomeOre
  {
    public string Block { get; set; }
    public float ProbabilityMin { get; set; }
    public float ProbabilityMax { get; set; }
    public float DepthMin { get; set; }
    public float DepthMax { get; set; }
  }
}