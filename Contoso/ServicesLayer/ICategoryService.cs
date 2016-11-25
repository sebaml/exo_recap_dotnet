using System;
using System.Collections.Generic;
using System.ServiceModel;
using DataModel;

namespace ServicesLayer
{
    [ServiceContract]
    public interface ICategoryService
    {
        [OperationContract]
        List<CategoryDetail> GetCategoryByName(string name);

        [OperationContract]
        List<CategoryDetail> GetCategories();

        [OperationContract]
        void DelCategory(long id);

        [OperationContract]
        bool UpdateCategory(CategoryDetail cd);

        [OperationContract]
        bool AddCategory(CategoryDetail cd);
    }
}