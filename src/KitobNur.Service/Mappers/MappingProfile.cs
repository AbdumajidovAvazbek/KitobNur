using AutoMapper;
using KitobNur.Domain.Entities.Books;
using KitobNur.Domain.Entities.Categories;
using KitobNur.Domain.Library;
using KitobNur.Domain.Users;
using KitobNur.Service.Dtos.Books;
using KitobNur.Service.Dtos.Books.InitBooks;
using KitobNur.Service.Dtos.Books.OrederBooks;
using KitobNur.Service.Dtos.Categories;
using KitobNur.Service.Dtos.Rentals;
using KitobNur.Service.Dtos.Users;

namespace KitobNur.Service.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Users
            CreateMap<User, UserForCreationDto>().ReverseMap();
            CreateMap<User, UserForResultDto>().ReverseMap();
            CreateMap<User, UserForUpdateDto>().ReverseMap();
            CreateMap<User, UserTypeForUpdateDto>().ReverseMap();
            CreateMap<User, UserStatusForUpdateDto>().ReverseMap();

            //Rental
            CreateMap<Rental, RentalForCreationDto>().ReverseMap();
            CreateMap<Rental, RentalForResultDto>().ReverseMap();

            //Book
            CreateMap<Book, BookForCreationDto>().ReverseMap();
            CreateMap<Book, BookForUpdateDto>().ReverseMap();
            CreateMap<Book, BookForResultDto>().ReverseMap();

            //OrderBook
            CreateMap<OrderBook, OrderBookDto>().ReverseMap();
            CreateMap<OrderBook, OrderBookForResultDto>().ReverseMap();

            //InitBook
            CreateMap<InitBook, InitBookDto>().ReverseMap();
            CreateMap<InitBook, InitBookForResultDto>().ReverseMap();

            //Category
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Category, CategoryResultDto>().ReverseMap();
        }
    }
}
