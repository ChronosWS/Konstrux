// <copyright file="BlockSounds.cs" company="Konstrux">
// Copyright (c) Konstrux. All rights reserved.
// Licensed under the "Creative Commons Attribution-ShareAlike 4.0 International Public License" license.
// See LICENSE file in the project root for full license information.
// </copyright>
// Author(s): Cliff Hudson

using System.Collections.Generic;

namespace Konstrux.Api.Loaders.BlockLoader
{
  public class BlockSounds
  {
    public string Pickup { get; set; }
    public string Build { get; set; }
    public string[] Footfalls { get; set; }
    public string Jump { get; set; }
    public string Landing { get; set; }
    public string Impact { get; set; }
    public string Destroy { get; set; }
  }
}