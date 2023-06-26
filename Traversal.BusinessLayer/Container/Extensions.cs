using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.BusinessLayer.Abstract;
using Traversal.BusinessLayer.Concrate;
using Traversal.BusinessLayer.ValidationRules;
using Traversal.DataAccessLayer.Abstract;
using Traversal.DataAccessLayer.EntityFramework;
using Traversal.DTOLayer.DTOs.AnnouncementDTOs;

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

            services.AddScoped<IContactUsDal, EfContactUsDal>();
            services.AddScoped<IContactUsService, ContactUsManager>();

            services.AddScoped<IGuideDal, EfGuideDal>();
            services.AddScoped<IGuideService, GuideManager>();

            services.AddScoped<IAppUserDal, EfAppUserDal>();
            services.AddScoped<IAppUserService, AppUserManager>();

            services.AddScoped<IExcelService, ExcelManager>();
            services.AddScoped<IPdfService, PdfManager>();

            services.AddScoped<IAnnouncementDal, EfAnnouncementDal>();
            services.AddScoped<IAnnouncementService, AnnouncementManager>();
        }
        public static void CustomValidator(this IServiceCollection services)
        {
            services.AddTransient<IValidator<AnnouncementAddDTO>, AnnouncementValidator>();
        }
    }
}
