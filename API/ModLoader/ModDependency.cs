// <copyright file="ModDependency.cs" company="Konstrux">
// Copyright (c) Konstrux. All rights reserved.
// Licensed under the "Creative Commons Attribution-ShareAlike 4.0 International Public License" license.
// See LICENSE file in the project root for full license information.
// </copyright>
// Author(s): Cliff Hudson

namespace Konstrux.Api.ModLoader
{
  public class ModDependency
  {
    public string Id { get; set; }
    public string MinVersion { get; set; }
    public string MaxVersion { get; set; }
  }
}