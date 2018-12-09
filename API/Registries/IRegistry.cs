// <copyright file="IRegistry.cs" company="Konstrux">
// Copyright (c) Konstrux. All rights reserved.
// Licensed under the "Creative Commons Attribution-ShareAlike 4.0 International Public License" license.
// See LICENSE file in the project root for full license information.
// </copyright>
// Author(s): Cliff Hudson

using System.Collections.Generic;

namespace Konstrux.Api.Registries
{
  public interface IRegistry<TData>: IEnumerable<IRegistryEntry<TData>>
  {
    string Name { get; set; }
    bool TryAdd(string name, TData data, out int id);
    bool TryAdd(string name, int id, TData data);
    bool TryRemove(string name);
    bool TryRemove(int id);
    TData this[string name] { get; set; }
    TData this[int id] { get; set; }
  }
}