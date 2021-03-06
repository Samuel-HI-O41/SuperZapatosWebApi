using Newtonsoft.Json;
using SuperZapatosWebApi.DbModels;
using SuperZapatosWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperZapatosWebApi.Controllers
{
    public class ServicesController : MainController
    {

        #region MethodsDefault
        // GET: Services
        public ActionResult Index()
        {
            return View();
        }

        // GET: Services/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Services/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Services/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Services/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Services/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic herez

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Services/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Services/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        #endregion

        #region Stores
        [HttpGet]
        public JsonResult Stores(string nameStore = null)
        {
            var response = new StoresResponse();

            try
            {
                List<Store> stores = string.IsNullOrWhiteSpace(nameStore) ? Repository.GetDataAccess().Stores.ToList() :
                                                                            Repository.GetDataAccess().Stores.Where(x => x.Name.Contains(nameStore)).ToList();
                response = new StoresResponse()
                {
                    stores = stores,
                    success = true,
                    total_elements = stores.Count()
                };

            }
            catch (Exception e)
            {
                response = new StoresResponse()
                {
                    success = false,
                    error_code = 500,
                    error_msg = "Server Error"
                };
                throw;
            }

            return Json(response, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult CreateStore(Store dataStore)
        {

            var response = new DtoResponse<int>();
            try
            {
                var newStore = new Store() { Name = dataStore.Name, Address = dataStore.Address };
                var insertStore = Repository.Insert<Store>(newStore);
                response.Estado = insertStore.Estado;
                response.Icono = insertStore.Icono;
                if (!insertStore.Estado)
                {
                    response.Resultado = 400;
                    response.Mensaje = "Bad request. " + insertStore.Mensaje;
                }
            }
            catch (Exception e)
            {
                response.Estado = false;
                response.Icono = IStatus.ERROR;
                response.Mensaje = "Server Error";
                response.Resultado = 500;
                throw;
            }

            return Json(response, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult UpdateStore(Store dataStore)
        {

            var response = new DtoResponse<int>();
            try
            {
                var storeDb = Repository.GetDataAccess().Stores.Where(x => x.Id == dataStore.Id).FirstOrDefault();
                if (storeDb == null)
                {
                    response.Estado = false;
                    response.Icono = IStatus.ERROR;
                    response.Resultado = 404;
                    response.Mensaje = "Record not found.";
                }
                else
                {
                    storeDb.Name = dataStore.Name;
                    storeDb.Address = dataStore.Address;
                    var insertStore = Repository.Update<Store>(storeDb);
                    response.Estado = insertStore.Estado;
                    response.Icono = insertStore.Icono;
                    if (!insertStore.Estado)
                    {
                        response.Resultado = 400;
                        response.Mensaje = "Bad request. " + insertStore.Mensaje;
                    }
                }

            }
            catch (Exception e)
            {
                response.Estado = false;
                response.Icono = IStatus.ERROR;
                response.Mensaje = "Server Error";
                response.Resultado = 500;
                throw;
            }

            return Json(response, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult DeleteStore(int id)
        {

            var response = new DtoResponse<int>();
            try
            {
                var storeDb = Repository.GetDataAccess().Stores.Where(x => x.Id == id).FirstOrDefault();
                if (storeDb == null)
                {
                    response.Estado = false;
                    response.Icono = IStatus.ERROR;
                    response.Mensaje = "Record not found";
                    response.Resultado = 404;
                }
                else
                {
                    var deleteStore = Repository.Delete<Store>(storeDb);
                    response.Estado = deleteStore.Estado;
                    response.Icono = deleteStore.Icono;
                    if (!deleteStore.Estado)
                    {
                        response.Resultado = 400;
                        response.Mensaje = "Bad request. " + deleteStore.Mensaje;
                    }
                }

            }
            catch (Exception e)
            {
                response.Estado = false;
                response.Icono = IStatus.ERROR;
                response.Mensaje = "Server Error";
                response.Resultado = 500;
                throw;
            }

            return Json(response, JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region Articles
        [HttpGet]
        public JsonResult Articles()
        {
            var response = new ArticlesResponse();

            try
            {
                List<Article> articles = Repository.GetDataAccess().Articles.Include("Store").ToList();
                response = new ArticlesResponse()
                {
                    articles = articles,
                    success = true,
                    total_elements = articles.Count()
                };

            }
            catch (Exception e)
            {
                response = new ArticlesResponse()
                {
                    success = false,
                    error_code = 500,
                    error_msg = "Server Error"
                };
                throw;
            }

            return Json(response, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult Articles_Stores(string id)
        {
            var response = new ArticlesResponse();
            int idStore;
            bool convertNumber = int.TryParse(id, out idStore);
            if (!convertNumber)
            {
                response = new ArticlesResponse()
                {
                    success = false,
                    error_code = 400,
                    error_msg = "Bad request"
                };
                return Json(response, JsonRequestBehavior.AllowGet);
            }

            try
            {
                var storeDb = idStore == 0 ? new Store() { } : Repository.GetDataAccess().Stores.Where(x => x.Id == idStore).FirstOrDefault();
                if (storeDb == null)
                {
                    response = new ArticlesResponse()
                    {
                        success = false,
                        error_code = 404,
                        error_msg = "Record not found"
                    };

                }
                else
                {
                    List<Article> articles = idStore == 0 ? Repository.GetDataAccess().Articles.Include("Store").ToList() : Repository.GetDataAccess().Articles.Include("Store").Where(x => x.StoreId == idStore).ToList();
                    response = new ArticlesResponse()
                    {
                        articles = articles,
                        success = true,
                        total_elements = articles.Count()
                    };
                }
            }
            catch (Exception e)
            {
                response = new ArticlesResponse()
                {
                    success = false,
                    error_code = 500,
                    error_msg = "Server Error"
                };
                throw;
            }

            return Json(response, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult CreateArticle(Article data)
        {

            var response = new DtoResponse<int>();
            try
            {
                var storeDb = Repository.GetDataAccess().Stores.Where(x => x.Id == data.StoreId).FirstOrDefault();
                if (storeDb == null)
                {
                    response.Estado = false;
                    response.Icono = IStatus.ERROR;
                    response.Resultado = 404;
                    response.Mensaje = "Record not found.";

                }
                else
                {
                    var newArticle = new Article()
                    {
                        Name = data.Name,
                        Description = data.Description,
                        Price = data.Price,
                        StoreId = storeDb.Id,
                        Total_in_shelf = data.Total_in_shelf,
                        Total_in_vault = data.Total_in_vault
                    };
                    var insertStore = Repository.Insert<Article>(newArticle);
                    response.Estado = insertStore.Estado;
                    response.Icono = insertStore.Icono;
                    if (!insertStore.Estado)
                    {
                        response.Resultado = 400;
                        response.Mensaje = "Bad request. " + insertStore.Mensaje;
                    }
                }
            }
            catch (Exception e)
            {
                response.Estado = false;
                response.Icono = IStatus.ERROR;
                response.Mensaje = "Server Error";
                response.Resultado = 500;
                throw;
            }

            return Json(response, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult UpdateArticle(Article data)
        {

            var response = new DtoResponse<int>();
            try
            {
                var articleDb = Repository.GetDataAccess().Articles.Where(x => x.Id == data.Id).FirstOrDefault();
                var storeDb = Repository.GetDataAccess().Stores.Where(x => x.Id == data.StoreId).FirstOrDefault();
                if (storeDb == null || articleDb == null)
                {
                    response.Estado = false;
                    response.Icono = IStatus.ERROR;
                    response.Resultado = 404;
                    response.Mensaje = "Record not found.";
                }
                else
                {
                    articleDb.StoreId = storeDb.Id;
                    articleDb.Name = data.Name;
                    articleDb.Description = data.Description;
                    articleDb.Price = data.Price;
                    articleDb.Total_in_shelf = data.Total_in_shelf;
                    articleDb.Total_in_vault = data.Total_in_vault;

                    var insertStore = Repository.Update<Article>(articleDb);
                    response.Estado = insertStore.Estado;
                    response.Icono = insertStore.Icono;
                    if (!insertStore.Estado)
                    {
                        response.Resultado = 400;
                        response.Mensaje = "Bad request. " + insertStore.Mensaje;
                    }
                }

            }
            catch (Exception e)
            {
                response.Estado = false;
                response.Icono = IStatus.ERROR;
                response.Mensaje = "Server Error";
                response.Resultado = 500;
                throw;
            }

            return Json(response, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult DeleteArticle(int id)
        {

            var response = new DtoResponse<int>();
            try
            {
                var articleDb = Repository.GetDataAccess().Articles.Where(x => x.Id == id).FirstOrDefault();
                if (articleDb == null)
                {
                    response.Estado = false;
                    response.Icono = IStatus.ERROR;
                    response.Resultado = 404;
                    response.Mensaje = "Record not found.";
                }
                else
                {
                    var deleteArticle = Repository.Delete<Article>(articleDb);
                    response.Estado = deleteArticle.Estado;
                    response.Icono = deleteArticle.Icono;
                    if (!deleteArticle.Estado)
                    {
                        response.Resultado = 400;
                        response.Mensaje = "Bad request. " + deleteArticle.Mensaje;
                    }
                }
            }
            catch (Exception e)
            {
                response.Estado = false;
                response.Icono = IStatus.ERROR;
                response.Mensaje = "Server Error";
                response.Resultado = 500;
                throw;
            }

            return Json(response, JsonRequestBehavior.AllowGet);
        }
        #endregion
    }
}
