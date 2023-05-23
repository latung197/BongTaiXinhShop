using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using BongTaiXinhShop.Model.Model;
using BongTaiXinhShop.Web.Models;

namespace BongTaiXinhShop.Web.Mappings
{
    public class AutomapperConfiguration
    {
        public static void Configure()
        {
            Mapper.CreateMap<Post, PostViewModel>();
            Mapper.CreateMap<PostCategory, PostCategoryViewModel>();
            Mapper.CreateMap<Tag, TagViewModel>();
        }   
    }
}