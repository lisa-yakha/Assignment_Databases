using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using System.IO;
using LibraryExample;


namespace SQLBasicsExample
{
    class WriteToFile
    {
        public static void ToFile(List<Models.Product> allProducts)
        {

            string folderpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\WriteToFile";
            bool exists = System.IO.Directory.Exists(folderpath);

            if (!exists)
            {
                System.IO.Directory.CreateDirectory(folderpath);
            }


            var writer = new StreamWriter($"{folderpath}\\file{DateTime.Now.ToString(("yyyyMMdd_HHmmss"))}.csv");
            var csvwriter = new CsvWriter(writer, CultureInfo.InvariantCulture);

            csvwriter.WriteRecords(allProducts);

            csvwriter.Dispose();
            writer.Dispose();

            var reader = new StreamReader($"{folderpath}\\file.csv");
            var csvreader = new CsvReader(reader, CultureInfo.InvariantCulture);

            //var output = csvreader.GetRecords<TestDataModel>().ToList();

        }

        /*class TestDataModel
        {
            public int val1 { get; set; }
            public string val2 { get; set; }
        }*/
    }
}
