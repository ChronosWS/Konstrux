// <copyright file="IRegistry.cs" company="Konstrux">
// Copyright (c) Konstrux. All rights reserved.
// Licensed under the "Creative Commons Attribution-ShareAlike 4.0 International Public License" license.
// See LICENSE file in the project root for full license information.
// </copyright>
// Author(s): Cliff Hudson

using System.Collections.Generic;
using Konstrux.Api.Common;

namespace Konstrux.Api.Registries
{
  public interface IRegistry<TData> : 
    IEnumerable<IRegistryEntry<TData>>, 
    IReadOnlyDictionary<string, TData>,
    IReadOnlyCollection<TData>
    where TData: INamed
  {
    string Name { get; }
    bool TryAdd(string name, TData data, out int id);
    bool TryAdd(string name, int id, TData data);
    bool TryRemove(string name);
    bool TryRemove(int id);
  }
}