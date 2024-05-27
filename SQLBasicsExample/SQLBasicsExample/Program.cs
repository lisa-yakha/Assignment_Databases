
using SQLBasicsExample;
using System.Linq;
using LibraryExample;
 

Data dbmanager = new Data();

//Insert new product

/*Models.Product product = new Models.Product();
product.Title = "Döner";
product.Price = 0.25; 

bool insertresult = dbmanager.InsertNewProduct(product);

Console.WriteLine(insertresult);*/

//Retrieve all products and write them to file
//WriteToFile.ToFile(dbmanager.RetrieveAllProducts());

//Retrieve  title by id
/*
string title = dbmanager.RetrieveTitleById("7892ED6B-CA64-464A-928C-0FFAD8C5DA44");

Console.WriteLine(title);
*/

//List<Models.Product> products = dbmanager.RetrieveAllProducts();

//var results = await dbmanager.SearchProduct("Beer");



Console.ReadKey();

//var filterresult =  products.Where(p => p.Title.Contains("B")).ToList();


//Console.WriteLine(filterresult.FirstOrDefault().Title);
 


/*
var singleresult = newlist.Find(p => p.Title.Contains("Beer")

bool filterresult = newlist.Remove());

Console.WriteLine(filterresult);*/