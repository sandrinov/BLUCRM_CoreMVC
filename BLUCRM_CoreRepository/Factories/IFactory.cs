using System;
using System.Collections.Generic;
using System.Text;

namespace BLUCRM_CoreRepository.Factories
{
    public interface IFactory<Entity, DTO>
    {
        Entity CreateEntity(DTO dto);
        DTO CreateDto(Entity entity);
    }
}
