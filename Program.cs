using HW_UsersControls.Data;
using HW_UsersControls.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace HW_UsersControls
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ConfigurationBuilder builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");
            IConfigurationRoot? config = builder.Build();
            string? stringConnection = config.GetConnectionString("DefaultConnection");
            DbContextOptionsBuilder<DataContext> optionsBuilder = new DbContextOptionsBuilder<DataContext>();
            DbContextOptions<DataContext> options = optionsBuilder.UseMySql(stringConnection, ServerVersion.Parse("8.0.30-mysql")).Options;
            DataContext db = new DataContext(options);

            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm(db));
        }
    }
}