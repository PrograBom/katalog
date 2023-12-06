using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KatalogLibrary.Models;
using Dapper;
using System.Data.SqlClient;

namespace KatalogLibrary.DataAccess;

public class SqlConnector
{

    private readonly string cnnString;
    public SqlConnector() 
    {
        cnnString = GlobalConfig.CnnString("ProductView") ?? throw new InvalidOperationException("Connection string is null.");
    }

    public List<Product> GetProduct_All()
    {
        List<Product> products = new List<Product>();
        using (IDbConnection connection = new SqlConnection(cnnString))
        {
            connection.Open();

            products = connection.Query<Product, Author, Category, Product>(
                @"SELECT 
                    P.*,
                    A.*,
                    C.*
                  FROM 
                    Products P
                    INNER JOIN Authors A ON P.AuthorId = A.Id
                    INNER JOIN Categories C ON P.CategoryId = C.Id",
                (product, author, category) =>
                {
                    product.Author = author;
                    product.Category = category;
                    return product;
                },
                splitOn: "Id,Id"
            ).ToList();
        }
        return products;
    }
}
