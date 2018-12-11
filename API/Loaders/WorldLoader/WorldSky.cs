// <copyright file="WorldSky.cs" company="Konstrux">
// Copyright (c) Konstrux. All rights reserved.
// Licensed under the "Creative Commons Attribution-ShareAlike 4.0 International Public License" license.
// See LICENSE file in the project root for full license information.
// </copyright>
// Author(s): Cliff Hudson

using System.Collections.Generic;

namespace Konstrux.Api.Loaders.WorldLoader
{
  public class WorldSky
  {
    public WorldClouds Clouds { get; set; }
    public WorldSkyBox SkyBox { get; set; }
    public string SkyTint { get; set; }
    public float DayCycleSpeed { get; set; }
    public int Azimuth { get; set; }
  }
}