using AutoMapper;
using DataLib.DTOs;
using EfAccessLib.Models;

namespace EfAccessLib.Configurations;

public class MapperConfig : Profile
{
	public MapperConfig()
	{
		CreateMap<TestModel, TestModelDto>().ReverseMap();
		CreateMap<TestModel, CreateTestModelDto>().ReverseMap();
	}
}