// Copyright © 2018 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using ExtCore.FileStorage;
using ExtCore.WebApplication.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace WebApplication
{
  public class Startup
  {
    private string extensionsPath;

    public Startup(IConfiguration configuration, IWebHostEnvironment webHostEnvironment)
    {
      this.extensionsPath = webHostEnvironment.ContentRootPath + configuration["Extensions:Path"];
    }

    public void ConfigureServices(IServiceCollection services)
    {
      services.AddExtCore(this.extensionsPath);
      services.Configure<FileStorageOptions>(options =>
        {
          options.RootPath = @"[Path to the solution]\ExtCore-Sample-FileStorage\src\WebApplication\FileStorage\Uploads";
          //options.Secret = "[Dropbox access token]";
          //options.RootPath = @"/";
        }
      );
    }

    public void Configure(IApplicationBuilder applicationBuilder, IWebHostEnvironment webHostEnvironment)
    {
      if (webHostEnvironment.IsDevelopment())
        applicationBuilder.UseDeveloperExceptionPage();

      applicationBuilder.UseExtCore();
    }
  }
}