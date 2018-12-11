// <copyright file="BlockMeta.cs" company="Konstrux">
// Copyright (c) Konstrux. All rights reserved.
// Licensed under the "Creative Commons Attribution-ShareAlike 4.0 International Public License" license.
// See LICENSE file in the project root for full license information.
// </copyright>
// Author(s): Cliff Hudson

using System.Collections.Generic;

namespace Konstrux.Api.Loaders.BlockLoader
{
  public class BlockMeta
  {
    public string Name { get; set; }
    public BlockSounds Sounds { get; set; }
    public int Resistance { get; set; }
    public bool Hidden { get; set; }
    public bool CanPickup { get; set; }
    public bool CanBeCollected { get; set; } 
    public int Height { get; set; }
    public string DiveColor { get; set; }
    public BlockFluid Fluid { get; set; }
    public int PlayerDamage { get; set; }
    public int PlayerDamageDelay { get; set; }
  }
}