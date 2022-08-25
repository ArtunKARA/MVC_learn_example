
using LrnEFCoreCodeFirst.DAL;
using Microsoft.EntityFrameworkCore;

DbContextInitalizer.Build();

using (var _context = new AppDbContext())
{
    var products = await _context.Products.ToListAsync();

    //Database ekleme yapılırken
    var newProduct = new Product { Name = "Kalem4", Price = 22.23m, Stock = 321, Barcode = "114" };//eklenecek parça yaplılır
    Console.WriteLine("ilkstate:" + _context.Entry(newProduct).State);
    await _context.AddAsync(newProduct);//eklenecek parça konulur
    Console.WriteLine("sonstate:" + _context.Entry(newProduct).State);
    await _context.SaveChangesAsync();//eklenecek parça kayıt edilir

    //Database günceleme yapılırken
    var product = await _context.Products.FirstAsync();//data baseden ilk parça getirilir
    Console.WriteLine("ilk state:" + _context.Entry(product).State);
    product.Stock = 123123;//değişiklik yapılır
    await _context.SaveChangesAsync();//değşiklik kayıt edilir
    Console.WriteLine("state after sonra:" + _context.Entry(product).State); ;
    /*Farklı bir komut */
    _context.Update(new Product() { Id = 5, Name = "Defter", Price = 200, Barcode = "110", Stock = 152 });

    //Database silme 
    product = await _context.Products.FirstAsync();//data baseden ilk parça getirilir
    Console.WriteLine("ilk state:" + _context.Entry(product).State);
    _context.Remove(product);//veri silinir
    await _context.SaveChangesAsync();//değşiklik kayıt edili
    Console.WriteLine("state after sonra:" + _context.Entry(product).State);

    //databsae okuma
    products = await _context.Products.AsNoTracking().ToListAsync();
    //AsNoTracking() sadece gelen verileri gösterir değişiklik yapılmasını engeler

    products.ForEach(async p =>
    {
        var state = _context.Entry(p).State;

        Console.WriteLine($"{p.Id}:{p.Name}-{p.Price}TL Stock({p.Stock}) {state}");
    });


    _context.ChangeTracker.Entries().ToList().ForEach(e =>
    {// trackerı değiştirelemediğinden sonuç vermez
        if(e.Entity is Product product)
        {
            product.Stock = 500; 
        }

    });

    //veri eklenirken tracker duumuna göre güncelenmek istenirse
    _context.Update(new Product() { Name = "Defter", Price = 200, Barcode = "110", Stock = 152 });

    _context.ChangeTracker.Entries().ToList().ForEach(e =>
    {
        if (e.Entity is Product p)
        {
            if (e.State == EntityState.Added)
            {//entity durumu added olduğ zamanlarda çalışır
                p.CreatedDate = DateTime.Now;
            }
        }
    });
    var product1 = await _context.Products.FirstAsync(x=>x.Id==10); // Gelen ilk veriyi alır
    var product2 = await _context.Products.SingleAsync(x => x.Id == 10);// Birden fazla değer gelirse Exception atar
    var product3 = await _context.Products.FindAsync(10);//keylerde istenilen özeliklere sahip veriyi getirir
    var product4 = await _context.Products.Where(x=>x.Id>10).ToListAsync();// İstenilen özellikteki verileri getirir

}