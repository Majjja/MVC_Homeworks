using PizzaApp.DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaApp.Services.Interfaces
{
    public interface IStoreService
    {
        List<StoreVM> GetAllStores();
        StoreVM GetStoreById(int id);
        bool CreateNewStore(StoreVM store);
        bool UpdateStore(StoreVM store);
        bool DeleteStore(StoreVM store);
    }
}
