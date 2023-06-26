﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.BusinessLayer.Abstract;
using Traversal.BusinessLayer.Concrate;
using Traversal.DataAccessLayer.Abstract;
using Traversal.DataAccessLayer.EntityFramework;

namespace Traversal.BusinessLayer.Container
{
    public static class  Extensions
    {
        public static void ContainerDependecies(this IServiceCollection services)
        {
            services.AddScoped<IDestinationDal, EfDestinationDal>();
            services.AddScoped<IDestinationService, DestinationManager>();

            services.AddScoped<IFeatureDal, EfFeatureDal>();
            services.AddScoped<IFeatureService, FeatureManager>();

            services.AddScoped<ISubAboutDal, EfSubAboutDal>();
            services.AddScoped<ISubAboutService, SubAboutManager>();

            services.AddScoped<ITestimonialDal, EfTestimonialDal>();
            services.AddScoped<ITestimonialService, TestimonialManager>();

            services.AddScoped<ICommentDal, EFCommentDal>();
            services.AddScoped<ICommentService, CommentManager>();

            services.AddScoped<IReservationDal, EfReservationDal>();
            services.AddScoped<IReservationService, ReservationManager>();

            services.AddScoped<IGuideDal, EfGuideDal>();
            services.AddScoped<IGuideService, GuideManager>();

            services.AddScoped<IAppUserDal, EfAppUserDal>();
            services.AddScoped<IAppUserService, AppUserManager>();

            services.AddScoped<IExcelService, ExcelManager>();
            services.AddScoped<IPdfService, PdfManager>();
        }
    }
}