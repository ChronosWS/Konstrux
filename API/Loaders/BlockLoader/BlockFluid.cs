// <copyright file="BlockFluid.cs" company="Konstrux">
// Copyright (c) Konstrux. All rights reserved.
// Licensed under the "Creative Commons Attribution-ShareAlike 4.0 International Public License" license.
// See LICENSE file in the project root for full license information.
// </copyright>
// Author(s): Cliff Hudson

using System.Collections.Generic;

namespace Konstrux.Api.Loaders.BlockLoader
{
  public class BlockFluid
  {
    public string DiveColor { get; set; }
    public bool SpreadEnabled { get; set; }
    public int SpreadDelay { get; set; }
    public int SpreadDelayRandom { get; set; }
    public bool DrainEnabled { get; set; }
  }
}