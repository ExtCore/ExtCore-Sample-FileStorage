// Copyright © 2018 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ExtCore.FileStorage.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Extension.Controllers
{
  public class DefaultController : Controller
  {
    private IFileStorage fileStorage;

    public DefaultController(IFileStorage fileStorage)
    {
      this.fileStorage = fileStorage;
    }

    [HttpGet]
    public async Task<ActionResult> Index()
    {
      IDirectoryProxy directoryProxy = this.fileStorage.CreateDirectoryProxy(@"\");
      IEnumerable<IFileProxy> fileProxies = await directoryProxy.GetFileProxiesAsync();
      IEnumerable<string> filenames = fileProxies.Select(fp => fp.Filename);

      return this.View(filenames);
    }

    [HttpPost]
    public async Task<ActionResult> Index(IEnumerable<IFormFile> files)
    {
      foreach (IFormFile file in files)
      {
        string filename = Path.GetFileName(file.FileName);
        IFileProxy fileProxy = this.fileStorage.CreateFileProxy(@"\", filename);

        await fileProxy.WriteStreamAsync(file.OpenReadStream());
      }

      return this.RedirectToAction("Index");
    }
  }
}