using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BongTaiXinhShop.Web.infrastructure.Core;
using BongTaiXinhShop.Service;
using BongTaiXinhShop.Model.Model;
using AutoMapper;
using BongTaiXinhShop.Web.Models;
using BongTaiXinhShop.Web.infrastructure.Extensions;
namespace BongTaiXinhShop.Web.Api

{
    [RoutePrefix("Api/postcategory")]
    public class PostCategoryController : ApiControllerBase
    {
        IPostCategoryService _postCategoryService;
        public PostCategoryController(IErrorService errorService, IPostCategoryService postCategoryService) : base(errorService)
        {
            this._postCategoryService = postCategoryService;
        }

        public HttpResponseMessage Post(HttpRequestMessage requestMessage, PostCategoryViewModel postCategory)
        {
            return CreateHttpResponse(requestMessage, () =>
            {
                HttpResponseMessage responseMessage = null;
                if (ModelState.IsValid)
                {
                    requestMessage.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    PostCategory _postCategory = new PostCategory();
                    _postCategory.UpdatePostCategory(postCategory);
                    _postCategoryService.Add(_postCategory);
                    _postCategoryService.Save();
                    responseMessage = requestMessage.CreateResponse(HttpStatusCode.OK);
                }
                return responseMessage;
                ;
            });
        }

        [Route("update")]
        public HttpResponseMessage Put(HttpRequestMessage requestMessage, PostCategoryViewModel postCategoryVm)
        {
            return CreateHttpResponse(requestMessage, () =>
            {
                HttpResponseMessage responseMessage = null;
                if (ModelState.IsValid)
                {
                    requestMessage.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    var _postCategory = _postCategoryService.GetById(postCategoryVm.ID);
                    _postCategory.UpdatePostCategory(postCategoryVm);
                    _postCategoryService.Add(_postCategory);
                    _postCategoryService.Save();
                    responseMessage = requestMessage.CreateResponse(HttpStatusCode.OK);
                }
                return responseMessage;
                ;
            });
        }

        public HttpResponseMessage Delete(HttpRequestMessage requestMessage, int Id)
        {
            return CreateHttpResponse(requestMessage, () =>
            {
                HttpResponseMessage responseMessage = null;
                if (ModelState.IsValid)
                {
                    requestMessage.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    _postCategoryService.Delete(Id);
                    _postCategoryService.Save();
                    responseMessage = requestMessage.CreateResponse(HttpStatusCode.OK);
                }
                return responseMessage;
                ;
            });
        }

        [Route("getall")]
        public HttpResponseMessage Get(HttpRequestMessage requestMessage)
        {
            return CreateHttpResponse(requestMessage, () =>
            {
                HttpResponseMessage responseMessage = null;
                //_postCategoryService.Add(postCategory);
                //_postCategoryService.Save();
                var listCategory = _postCategoryService.GetAll();

                var listPostCategoryVm = Mapper.Map<List<PostCategoryViewModel>>(listCategory);
                responseMessage = requestMessage.CreateResponse(HttpStatusCode.OK, listPostCategoryVm);
                return responseMessage;
            });
        }

    }
}