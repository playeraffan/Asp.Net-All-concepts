namespace Project
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();


            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=About}/{id?}");

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.MapControllerRoute(
           name: "default",
           pattern: "{controller=Home}/{action=Contact}/{id?}");


            app.MapControllerRoute(
           name: "default",
           pattern: "{controller=Home}/{action=Services}/{id?}");


            app.MapControllerRoute(
             name: "default",
             pattern: "{controller=About}/{action=Index}/{id?}");


            //app.Use(async (Context , next) =>
            //{
            //    await Context.Response.WriteAsync("Proceed to be!");
            //    await next();
            //}
            //);

            //app.Use(async (Context , next) =>
            //{
            //    await Context.Response.WriteAsync("\nAgain Proceed to be!");
            //    await next();
            //}
            //);

            //app.Run(async (Context) =>
            //    {
            //        await Context.Response.WriteAsync("\nWelcome");
            //    }
            //  );


            app.Run();
        }
    }
}
