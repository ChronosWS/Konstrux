// <copyright file="Registry.cs" company="Konstrux">
// Copyright (c) Konstrux. All rights reserved.
// Licensed under the "Creative Commons Attribution-ShareAlike 4.0 International Public License" license.
// See LICENSE file in the project root for full license information.
// </copyright>
// Author(s): Cliff Hudson

using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Konstrux.Api.Registries
{
  public class Registry<TData> : IRegistry<TData>
  {
    private class RegistryEntry : IRegistryEntry<TData>
    {
      public string Name { get; set; }
      public int Id { get; set; }
      public TData Data { get; set; }
    }

    private Dictionary<string, RegistryEntry> nameMapping = new Dictionary<string, RegistryEntry>();
    private List<RegistryEntry> idMapping = new List<RegistryEntry>();

    public TData this[string name] => this.nameMapping[name].Data;

    public TData this[int id] => this.idMapping[id].Data;

    public string Name { get; private set; }

    public IEnumerable<string> Keys => this.nameMapping.Keys;

    public IEnumerable<TData> Values => this.idMapping.Select(p => p.Data);

    public int Count => throw new System.NotImplementedException();

    public static IRegistry<TData> Create(string name) {
      return new Registry<TData> {
        Name = name
      };
    }

    public IEnumerator<IRegistryEntry<TData>> GetEnumerator() => this.idMapping.GetEnumerator();

    public bool TryAdd(string name, TData data, out int id)
    {
      if (!this.nameMapping.ContainsKey(name))
      {
        var entry = new RegistryEntry
        {
          Name = name,
          Id = this.idMapping.Count,
          Data = data
        };

        this.nameMapping.Add(name, entry);
        this.idMapping.Add(entry);
        id = entry.Id;
        return true;
      }

      id = -1;
      return false;
    }

    public bool TryAdd(string name, int id, TData data)
    {
      throw new System.NotImplementedException();
    }

    public bool TryRemove(string name)
    {
      throw new System.NotImplementedException();
    }

    public bool TryRemove(int id)
    {
      throw new System.NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator() => this.idMapping.GetEnumerator();

    public bool ContainsKey(string key) => this.nameMapping.ContainsKey(key);

    public bool TryGetValue(string key, out TData value)
    {
      if(this.nameMapping.TryGetValue(key, out var entry)) {
        value = entry.Data;
        return true;
      }

      value = default(TData);
      return false;
    }

    IEnumerator<KeyValuePair<string, TData>> IEnumerable<KeyValuePair<string, TData>>.GetEnumerator()
    {
      foreach(var entry in this.nameMapping) {
        yield return new KeyValuePair<string, TData>(entry.Key, entry.Value.Data);
      }
    }

    IEnumerator<TData> IEnumerable<TData>.GetEnumerator()
    {
      foreach(var data in this.idMapping.Select(p => p.Data)) {
        yield return data;
      }
    }
  }
}