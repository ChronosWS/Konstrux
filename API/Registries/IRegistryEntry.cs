// <copyright file="IRegistryEntry.cs" company="Konstrux">
// Copyright (c) Konstrux. All rights reserved.
// Licensed under the "Creative Commons Attribution-ShareAlike 4.0 International Public License" license.
// See LICENSE file in the project root for full license information.
// </copyright>
// Author(s): Cliff Hudson

namespace Konstrux.Api.Registries
{
  public interface IRegistryEntry<TData> {
    string Name { get; set; }
    int Id { get; set; }
    TData Data { get; set; }
  }
}