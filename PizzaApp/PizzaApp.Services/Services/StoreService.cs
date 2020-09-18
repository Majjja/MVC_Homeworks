using PizzaApp.DataAccess.Domain.Interfaces;
using PizzaApp.DataAccess.Domain.Models;
using PizzaApp.DataAccess.ViewModels;
using PizzaApp.Services.Interfaces;
using PizzaApp.Services.MappingToDM;
using PizzaApp.Services.MappingToVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace PizzaApp.Services.Services
{
    public class StoreService : IStoreService
    {
        private IRepository<Store> _storeRepo;
        public StoreService(IRepository<Store> storeRepo)
        {
            _storeRepo = storeRepo;
        }
        public bool CreateNewStore(StoreVM storeVM)
        {
            var storeDomain = MapperToDM.MapStoreVMToStore(storeVM);
            var store = _storeRepo.GetAll().SingleOrDefault(x => x.Id == storeDomain.Id);
            if (store == null)
            {
                _storeRepo.GetAll().Add(store);
                return true;
            }
            return false;
        }

        public bool DeleteStore(StoreVM storeVM)
        {
            var storeDomain = MapperToDM.MapStoreVMToStore(storeVM);
            var store = _storeRepo.GetAll().SingleOrDefault(x => x.Id == storeDomain.Id);
            if (store == null)
            {
                return false;
            }
            _storeRepo.GetAll().Remove(store);
            return true;
        }

        public List<StoreVM> GetAllStores()
        {
            var stores = _storeRepo.GetAll();
            var storesVM = MapperToVM.MapStoresToStoresVM(stores);
            return storesVM;
        }

        public StoreVM GetStoreById(int id)
        {
            var store = _storeRepo.GetAll().SingleOrDefault(x => x.Id == id);
            var storeDomain = MapperToVM.MapStoreToStoreVM(store);
            return storeDomain;
        }

        public bool UpdateStore(StoreVM storeVM)
        {
            var storeDomain = MapperToDM.MapStoreVMToStore(storeVM);
            var store = _storeRepo.GetAll().SingleOrDefault(x => x.Id == storeDomain.Id);
            if (store == null)
            {
                return false;
            }
            int index = _storeRepo.GetAll().IndexOf(store);
            _storeRepo.GetAll()[index] = storeDomain;
            return true;
        }


        //public IActionResult Details(int id)
        //{
        //    var pizzasVM = StaticDB.ListOfPizzas.Select(pizza => new PizzaVM()
        //    {
        //        Id = pizza.Id,
        //        Name = pizza.Name,
        //        Size = pizza.Size,
        //        Price = pizza.Price,
        //        Ingredients = pizza.Ingredients,
        //        ImgUrl = pizza.ImgUrl
        //    }).ToList();

        //    var store = StaticDB.ListOfStores.SingleOrDefault(x => x.Id == id);
        //    var storeVM = new StoreVM()
        //    {
        //        Id = store.Id,
        //        Name = store.Name,
        //        Address = store.Address,
        //        City = store.City,
        //        PhoneNumber = store.PhoneNumber,
        //        PizzaIds = store.PizzaIds
        //    };

        //    var pizzasNames = new List<PizzaVM>();
        //    foreach (var item in storeVM.PizzaIds)
        //    {
        //        foreach (var pizza in pizzasVM)
        //        {
        //            if (item == pizza.Id)
        //            {
        //                pizzasNames.Add(pizza);
        //            }
        //        }
        //    }
        //    ViewBag.Welcome = "Welcome to  " + store.Name;
        //    ViewBag.PizzaNames = pizzasNames;
        //    return View(pizzasNames);
        //}
    }
}
