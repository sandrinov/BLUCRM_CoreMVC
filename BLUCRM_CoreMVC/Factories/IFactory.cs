﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLUCRM_CoreMVC.Factories
{
    public interface IFactory<Entity, DTO>
    {
        Entity CreateEntity(DTO dto);
        DTO CreateDto(Entity entity);
    }
}