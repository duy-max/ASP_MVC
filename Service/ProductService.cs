using System.Collections.Generic;
using App.Models;

namespace App.Services
{
    public class ProductService : List<ProductsModel>
    {
        public ProductService(){
            this.AddRange(new ProductsModel[]{
                new ProductsModel(){ ID =1 , Name="Iphone X", Price=1000},
                new ProductsModel(){ ID =2 , Name="Iphone X", Price=1000},
                new ProductsModel(){ ID =3 , Name="Iphone X", Price=1000},
                new ProductsModel(){ ID =4 , Name="Iphone X", Price=1000},

            });
        }

    }
}