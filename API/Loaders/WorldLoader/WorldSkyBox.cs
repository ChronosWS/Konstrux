// <copyright file="WorldSkyBox.cs" company="Konstrux">
// Copyright (c) Konstrux. All rights reserved.
// Licensed under the "Creative Commons Attribution-ShareAlike 4.0 International Public License" license.
// See LICENSE file in the project root for full license information.
// </copyright>
// Author(s): Cliff Hudson

using System.Collections.Generic;

namespace Konstrux.Api.Loaders.WorldLoader
{
  public class WorldSkybox
  {
    public string Shader { get; set; }
    public string CubemapNightTexture { get; set; }
    public string CubemapDayTexture { get; set; }
  }
}