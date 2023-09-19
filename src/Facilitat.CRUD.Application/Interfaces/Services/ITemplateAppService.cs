﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Facilitat.CRUD.Application.Dtos;

namespace Facilitat.CRUD.Application.Interfaces.Services
{
    public interface ITemplateAppService
	{
        Task<IEnumerable<TemplateDto>> GetAllTemplatesAsync();
        Task<TemplateDto> GetByIdTemplateAsync(int templateDtoId);
        Task<TemplateDto> InsertTemplateAsync(TemplateDto templateDto);
        Task<TemplateDto> UpdateTemplateAsync(int templateId, TemplateDto templateDto);
    }
}

