﻿using AutoMapper;

namespace ProjetoModeloDDD.MVC.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<DomainToViewModelMappingsProfile>();
                x.AddProfile<ViewModelToDomainMappingsProfile>();
            });
        }
    }
}