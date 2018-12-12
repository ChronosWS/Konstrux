// <copyright file="ITextureLoader.cs" company="Konstrux">
// Copyright (c) Konstrux. All rights reserved.
// Licensed under the "Creative Commons Attribution-ShareAlike 4.0 International Public License" license.
// See LICENSE file in the project root for full license information.
// </copyright>
// Author(s): Cliff Hudson

using System.Threading.Tasks;
using Konstrux.Api.Registries;

namespace Konstrux.Api.Loaders.TextureLoader {
  public interface ITextureLoader: IRegistryLoader<TextureMeta> {
  }
}