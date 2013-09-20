using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using EShop.Core;
using EShop.CoreAccess;

namespace EShop.Web.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<EShopDbContext>
    {
        protected override void Seed(EShopDbContext context)
        {
            new List<Company>
                {
                    new Company {CompanyName = "Dell"},
                    new Company {CompanyName = "HP"},
                    new Company {CompanyName = "GUCCI", IsBrand = true},
                    new Company {CompanyName = "GIORDANO", IsBrand = true},
                    new Company {CompanyName = "LEVI'S", IsBrand = true}
                }.ForEach(a => context.Companies.Add(a));

            new List<User>
                {
                    new User()
                        {
                            LoginName = "Elvin",
                            Password = "123",
                            Email = "elvin.arzumanoglu@gmail.com",
                            Position = PositionEnum.Admin,
                            Status = StatusEnum.Active
                        },
                    new User()
                        {
                            LoginName = "Zamir",
                            Password = "123",
                            Email = "zamirmmmm@gmail.com",
                            Position = PositionEnum.Admin,
                            Status = StatusEnum.Active
                        }
                }.ForEach(a => context.Users.Add(a));

            var mainCategory = new List<Category>
                {
                    new Category {CategoryName = "TV"},
                    new Category {CategoryName = "Telefon"},
                    new Category {CategoryName = "Elektronika"},
                    new Category {CategoryName = "Foto kamera"},
                    new Category {CategoryName = "Saat"}
                };



            new List<Category>
                {
                    new Category
                        {
                            CategoryName = "Mobil Telefon",
                            MainCategory = mainCategory.Single(c => c.CategoryName == "Telefon")
                        },
                    new Category
                        {
                            CategoryName = "Ev Telefonu",
                            MainCategory = mainCategory.Single(c => c.CategoryName == "Telefon")
                        }
                }.ForEach(a => context.Categories.Add(a));
        }
    }
}