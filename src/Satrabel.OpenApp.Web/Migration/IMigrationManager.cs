﻿using Abp.Configuration.Startup;
using Abp.Dependency;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Satrabel.OpenApp.Web.Migration
{
    public interface IMigrationManager
    {
        Version AppVersion { get; set; }
        bool NeedMigration { get; }
        IApplicationLifetime ApplicationLifetime { get; set; }
        IHostingEnvironment HostingEnvironment { get; set; }

        void Configure(IAbpStartupConfiguration Configuration, IIocManager IocManager);

        void Run<T>(IIocManager iocManager)
            where T : IMigratorExecuter;
    }
}
