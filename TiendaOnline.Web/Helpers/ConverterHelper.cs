using System;
using System.Threading.Tasks;
using TiendaOnline.Web.Models;

namespace TiendaOnline.Web.Helpers
{
    public class ConverterHelper : IConverterHelper
    {
        public Category ToCategory(CategoryViewModel model, Guid imageId, bool isNew)
        {
            return new Category
            {
                Id = isNew ? 0 : model.Id,
                ImageId = imageId,
                Name = model.Name
            };
        }

        public CategoryViewModel ToCategoryViewModel(Category category)
        {
            return new CategoryViewModel
            {
                Id = category.Id,
                ImageId = category.ImageId,
                Name = category.Name
            };
        }

        public Task<Product> ToProductAsync(ProductViewModel model, bool isNew)
        {
            throw new NotImplementedException();
        }

        public ProductViewModel ToProductViewModel(Product product)
        {
            throw new NotImplementedException();
        }




    }




}
