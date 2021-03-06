﻿using Chilicki.Paint.Application.Managers;
using Chilicki.Paint.Domain.Factories;
using Chilicki.Paint.UserInterface.ViewModel;
using Ninject.Modules;

namespace Chilicki.Paint.UserInterface.Config
{
    class DependencyInjectionBindings : NinjectModule
    {
        public override void Load()
        {
            Bind<PaintViewModel>().ToSelf();

            Bind<PaintManager>().ToSelf();

            Bind<FileManager>().ToSelf();

            Bind<ToolFactory>().ToSelf();     

            // TODO Bind all image loaders and savers in infrastructure
        }
    }
}
