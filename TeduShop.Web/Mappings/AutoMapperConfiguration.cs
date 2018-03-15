using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TeduShop.Model.Models;
using TeduShop.Web.Models;

namespace TeduShop.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            //Mapper.CreateMap<Post, PostViewModel>();
            //Mapper.CreateMap<PostCategory, PostCategoryViewModel>();
            //Mapper.CreateMap<Tag, TagViewModel>();
            //Mapper.CreateMap<PostTag, PostTagViewModel>();

            Mapper.Initialize(cfg =>
            {
                //cfg.CreateMap<Category, CategoryViewModel>().MaxDepth(2);
                cfg.CreateMap<Post, PostViewModel>().MaxDepth(2);
                cfg.CreateMap<Tag, TagViewModel>().MaxDepth(2);
                //cfg.CreateMap<Ebook, EbookViewModel>().MaxDepth(2);
                //cfg.CreateMap<Page, PageViewModel>().MaxDepth(2);
                //cfg.CreateMap<CourseCategory, CourseCategoryViewModel>().MaxDepth(2);
                //cfg.CreateMap<Course, CourseViewModel>().MaxDepth(2);
                //cfg.CreateMap<AppGroup, AppGroupViewModel>().MaxDepth(2);
                //cfg.CreateMap<AppRole, AppRoleViewModel>().MaxDepth(2);
                //cfg.CreateMap<AppUser, AppUserViewModel>().MaxDepth(2);
                //cfg.CreateMap<AppUserGroup, AppUserGroupViewModel>().MaxDepth(2);
                //cfg.CreateMap<Trainer, TrainerViewModel>().MaxDepth(2);
                //cfg.CreateMap<CourseVideo, CourseVideoViewModel>().MaxDepth(2);
                //cfg.CreateMap<TechLine, TechLineViewModel>().MaxDepth(2);
                //cfg.CreateMap<CourseUser, CourseUserViewModel>().MaxDepth(2);
                //cfg.CreateMap<CourseReview, CourseReviewViewModel>().MaxDepth(2);
                //cfg.CreateMap<PaymentMethod, PaymentMethodViewModel>().MaxDepth(2);
                //cfg.CreateMap<TransactionLog, TransactionLogViewModel>().MaxDepth(2);
                //cfg.CreateMap<VideoComment, VideoCommentViewModel>().MaxDepth(2);
                //cfg.CreateMap<Notification, NotificationViewModel>().MaxDepth(2);
                //cfg.CreateMap<Footer, FooterViewModel>().MaxDepth(2);

            });
        }
    }
}