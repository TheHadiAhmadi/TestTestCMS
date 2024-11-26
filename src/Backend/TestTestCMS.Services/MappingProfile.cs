﻿using AutoMapper;

namespace TestTestCMS.Services;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Layout, Layout>();
        CreateMap<Block, Block>();
        CreateMap<PageTemplate, PageTemplate>();
        CreateMap<Role, Role>();
        CreateMap<SiteTemplate, Site>();
        CreateMap<SiteTemplate, SiteTemplate>();
        CreateMap<PluginDefinition, PluginDefinition>();
        CreateMap<ContentTypeTemplate, ContentTypeTemplate>();
        CreateMap<Page, PageModel>();
    }
}
