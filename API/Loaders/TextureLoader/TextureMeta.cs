// <copyright file="TextureMeta.cs" company="Konstrux">
// Copyright (c) Konstrux. All rights reserved.
// Licensed under the "Creative Commons Attribution-ShareAlike 4.0 International Public License" license.
// See LICENSE file in the project root for full license information.
// </copyright>
// Author(s): Cliff Hudson

using System.Collections.Generic;
using Konstrux.Api.Common;

namespace Konstrux.Api.Loaders.TextureLoader
{
  public class TextureMeta : INamed
  {
    public string Name { get; set; }
    public string Path { get; set; }
    public TextureParameters Parameters { get; set; }
  }
}