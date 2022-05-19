namespace TiendaOnline.Web.Helpers
{
    using System;
    using System.Threading.Tasks;
    using TiendaOnline.Web.Models;


    public interface IConverterHelper
    {
        Category ToCategory(CategoryViewModel model, Guid imageId, bool isNew);

        CategoryViewModel ToCategoryViewModel(Category category);

        Task<Product> ToProductAsync(ProductViewModel model, bool isNew);

        ProductViewModel ToProductViewModel(Product product);

    }



}
