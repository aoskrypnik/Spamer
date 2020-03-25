using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Constants
{
    public static class Constants
    {
        public static string ConnectionString =>
            "User ID = andrew; Password=root;Server=localhost;Port=5432;Database=MyWebApi.Dev;Integrated Security=true; Pooling=true;";

        public static DbContextOptions<MyWebApiContext> DbContextOptions =>
            new DbContextOptionsBuilder<MyWebApiContext>().UseNpgsql(ConnectionString).Options;
    }
}