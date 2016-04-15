using System.Web.Http;
using IdentityServer3.AccessTokenValidation;
using Microsoft.Owin;
using Owin;
using WebApi.App_Start;

[assembly: OwinStartup(typeof(WebApi.Startup))]

namespace WebApi
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseIdentityServerBearerTokenAuthentication(new IdentityServerBearerTokenAuthenticationOptions
            {
                Authority = Application.Constants.Constants.STS,
                RequiredScopes = new[] { "gallerymanagement" }
            });

            HttpConfiguration httpConfiguration = new HttpConfiguration();
            WebApiConfig.Register(httpConfiguration);
            app.UseWebApi(httpConfiguration);
        }

        //private void InitAutoMapper()
        //{
        //    Mapper.CreateMap<Repository.Entities.Trip,
        //        DTO.Trip>().ForMember(dest => dest.MainPictureUri,
        //        op => op.ResolveUsing(typeof(InjectImageBaseForTripResolver)));

        //    Mapper.CreateMap<Repository.Entities.Picture,
        //        DTO.Picture>()
        //        .ForMember(dest => dest.Uri,
        //        op => op.ResolveUsing(typeof(InjectImageBaseForPictureResolver)));

        //    Mapper.CreateMap<DTO.Picture,
        //      Repository.Entities.Picture>();


        //    Mapper.CreateMap<DTO.Trip,
        //        Repository.Entities.Trip>().ForMember(dest => dest.MainPictureUri,
        //        op => op.ResolveUsing(typeof(RemoveImageBaseForTripResolver))); ;

        //    Mapper.CreateMap<DTO.PictureForCreation,
        //        Repository.Entities.Picture>()
        //        .ForMember(o => o.Id, o => o.Ignore())
        //        .ForMember(o => o.TripId, o => o.Ignore())
        //        .ForMember(o => o.OwnerId, o => o.Ignore())
        //        .ForMember(o => o.Uri, o => o.Ignore());


        //    Mapper.CreateMap<DTO.TripForCreation,
        // Repository.Entities.Trip>()
        //    .ForMember(o => o.Id, o => o.Ignore())
        //    .ForMember(o => o.MainPictureUri, o => o.Ignore())
        //    .ForMember(o => o.Pictures, o => o.Ignore())
        //    .ForMember(o => o.OwnerId, o => o.Ignore());


        //    Mapper.AssertConfigurationIsValid();
        //}
    }
}
