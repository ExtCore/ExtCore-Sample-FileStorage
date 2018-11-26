// Copyright © 2018 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using ExtCore.FileStorage;
using ExtCore.WebApplication.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace WebApplication
{
  public class Startup
  {
    private string extensionsPath;

    public Startup(IHostingEnvironment hostingEnvironment, IConfiguration configuration)
    {
      this.extensionsPath = hostingEnvironment.ContentRootPath + configuration["Extensions:Path"];
    }

    public void ConfigureServices(IServiceCollection services)
    {
      services.AddExtCore(this.extensionsPath);
      services.Configure<FileStorageOptions>(options =>
        {
          options.RootPath = @"[Path to the solution]\ExtCore-Sample-FileStorage\src\WebApplication\FileStorage";
		  //options.Secret = "[Dropbox access token]";
          //options.RootPath = @"/";
        }
      );
    }

    public void Configure(IApplicationBuilder applicationBuilder)
    {
      applicationBuilder.UseDeveloperExceptionPage();
      applicationBuilder.UseExtCore();
    }
  }
}