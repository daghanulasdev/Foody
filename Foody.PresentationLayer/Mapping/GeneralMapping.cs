using AutoMapper;
using Foody.DtoLayer.Dtos.AboutDtos;
using Foody.DtoLayer.Dtos.AddressDtos;
using Foody.DtoLayer.Dtos.CategoryDtos;
using Foody.DtoLayer.Dtos.FeatureDtos;
using Foody.DtoLayer.Dtos.ProductDtos;
using Foody.DtoLayer.Dtos.ReviewDtos;
using Foody.DtoLayer.Dtos.SliderDtos;
using Foody.DtoLayer.Dtos.SocialMediaDtos;
using Foody.EntityLayer.Concrete;

namespace Foody.PresentationLayer.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {

            #region About
            CreateMap<CreateAboutDto, About>().ReverseMap();
            CreateMap<UpdateAboutDto, About>().ReverseMap();
            CreateMap<ResultAboutDto, About>().ReverseMap();
            CreateMap<GetByIdAboutDto, About>().ReverseMap();
            #endregion

            #region Address
            CreateMap<CreateAddressDto, Address>().ReverseMap();
            CreateMap<UpdateAddressDto, Address>().ReverseMap();
            CreateMap<ResultAddressDto, Address>().ReverseMap();
            CreateMap<GetByIdAddressDto, Address>().ReverseMap();
            #endregion

            #region Category
            CreateMap<CreateCategoryDto, Category>().ReverseMap();
            CreateMap<UpdateCategoryDto, Category>().ReverseMap();
            CreateMap<ResultCategoryDto, Category>().ReverseMap();
            CreateMap<GetByIdCategoryDto, Category>().ReverseMap();
            #endregion

            #region Feature
            CreateMap<CreateFeatureDto, Feature>().ReverseMap();
            CreateMap<UpdateFeatureDto, Feature>().ReverseMap();
            CreateMap<ResultFeatureDto, Feature>().ReverseMap();
            CreateMap<GetByIdFeatureDto, Feature>().ReverseMap();
            #endregion

            #region Product
            CreateMap<CreateProductDto, Product>().ReverseMap();
            CreateMap<UpdateProductDto, Product>().ReverseMap();
            CreateMap<ResultProductDto, Product>().ReverseMap();
            CreateMap<GetByIdProductDto, Product>().ReverseMap();
            #endregion

            #region Review
            CreateMap<CreateReviewDto, Review>().ReverseMap();
            CreateMap<UpdateReviewDto, Review>().ReverseMap();
            CreateMap<ResultReviewDto, Review>().ReverseMap();
            CreateMap<GetByIdReviewDto, Review>().ReverseMap();
            #endregion

            #region Slider
            CreateMap<CreateSliderDto, Slider>().ReverseMap();
            CreateMap<UpdateSliderDto, Slider>().ReverseMap();
            CreateMap<ResultSliderDto, Slider>().ReverseMap();
            CreateMap<GetByIdSliderDto, Slider>().ReverseMap();
            #endregion

            #region SocialMedia
            CreateMap<CreateSocialMediaDto, SocialMedia>().ReverseMap();
            CreateMap<UpdateSocialMediaDto, SocialMedia>().ReverseMap();
            CreateMap<ResultSocialMediaDto, SocialMedia>().ReverseMap();
            CreateMap<GetByIdSocialMediaDto, SocialMedia>().ReverseMap(); 
            #endregion
        }
    }
}
