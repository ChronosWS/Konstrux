// <copyright file="ModMeta.cs" company="Konstrux">
// Copyright (c) Konstrux. All rights reserved.
// Licensed under the "Creative Commons Attribution-ShareAlike 4.0 International Public License" license.
// See LICENSE file in the project root for full license information.
// </copyright>
// Author(s): Cliff Hudson

using System.Collections.Generic;

namespace Konstrux.Api.Loaders.ModLoader
{
  public class ModMeta
  {
    public string Name { get; set; }
    public string DisplayName { get; set; }
    public string Description { get; set; }
    public string Version { get; set; }
    public string GameVersion { get; set; }
    public string SiteUrl { get; set; }
    public string DownloadUrl { get; set; }
    public List<ModAuthor> Authors { get; set; }
    public List<ModDependency> Dependencies { get; set; }
    public string Logo { get; set; }
    public List<ModScreenshot> Screenshots { get; set; }
  }
}