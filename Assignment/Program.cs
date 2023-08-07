using Assignment.Core.Context;
using Assignment.Core.Repository;
using Autofac;

namespace Assignment
{
    internal static class Program
    {
        static IContainer container;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            container = Configure();
            var resolve1 = container.Resolve<IUserRepo>();
            var resolve2 = container.Resolve<IStudentRepo>();
            Application.Run(new Login(resolve1,resolve2));
        }

        static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<UserDbContext>().AsSelf();
            builder.RegisterType<StudentDbContext>().AsSelf();
            builder.RegisterType<UserRepo>().As<IUserRepo>();
            builder.RegisterType<StudentRepo>().As<IStudentRepo>();
            builder.RegisterType<Login>();
            return builder.Build();
        }
    }
}