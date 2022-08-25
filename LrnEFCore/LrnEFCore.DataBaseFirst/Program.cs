
using LrnEFCore.DataBaseFirst.DAL;
using Microsoft.EntityFrameworkCore;

DbContextInitializer.Build();

using (var _context = new AppDbContext(DbContextInitializer.OptionsBuilder.Options))//Veri tabanı na erişim yapılıp sonra değişkenlerden kurtulmak için using kullanılır.
{                     //Dinamik Olarak Database bağlantı ayarları yapmak için kullanılır
    var products = await _context.Products.ToListAsync();//Products veri tabanı üzerine erişip producun üsütne koyar

    products.ForEach(p =>
    {
        Console.WriteLine($"{p.Id}:{p.Name}-{p.Price}TL Stock({p.Stock})");
    });
}
