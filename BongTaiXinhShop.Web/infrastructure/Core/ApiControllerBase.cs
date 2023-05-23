using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BongTaiXinhShop.Service;
using BongTaiXinhShop.Data.Repositorys;
using BongTaiXinhShop.Model.Model;
using System.Data.Entity.Validation;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;

namespace BongTaiXinhShop.Web.infrastructure.Core
{
    public class ApiControllerBase : ApiController
    {
        private IErrorService _errorService;
        public ApiControllerBase(IErrorService errorService)
        {
            this._errorService = errorService;
        }

        protected HttpResponseMessage CreateHttpResponse(HttpRequestMessage requestMessage, Func<HttpResponseMessage> funtion)
        {
            HttpResponseMessage responseMessage = null;
            try
            {
                responseMessage = funtion.Invoke();
            }
            catch(DbEntityValidationException dbex)
            {
                foreach(var ex in dbex.EntityValidationErrors)
                {
                    Trace.WriteLine($"Entity of type\"{ex.Entry.Entity.GetType().Name}\" in state\"{ex.Entry.State}\" has the fllowing validation errores;");
                    foreach(var ve in ex.ValidationErrors)
                    {
                        Console.WriteLine("- Property : \"{0}\", Errore:\"{1}\"",ve.PropertyName,ve.ErrorMessage);
                    }
                }

                LogError(dbex);
                responseMessage = requestMessage.CreateResponse(HttpStatusCode.BadRequest, dbex.InnerException.Message);
            }

            catch (DbUpdateException dbex)
            {
                LogError(dbex);
                responseMessage = requestMessage.CreateResponse(HttpStatusCode.BadRequest, dbex.InnerException.Message);
            }

            catch (Exception ex)
            {
                LogError(ex);
                responseMessage = requestMessage.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }

            return responseMessage;
        }

        private void LogError(Exception ex)
        {
            try
            {
                Error error = new Error();
                error.CreatedDate = DateTime.Now;
                error.Message = ex.Message;
                error.StackTrace = ex.StackTrace;
                _errorService.Create(error);
                _errorService.Save();
            }
            catch
            {

            }
        }
    }
}
