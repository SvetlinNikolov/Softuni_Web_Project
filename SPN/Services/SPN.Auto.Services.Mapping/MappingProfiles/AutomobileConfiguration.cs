﻿using AutoMapper;
using SPN.Auto.Data.Models;
using SPN.Auto.Web.InputModels.Automobile;
using System;
using System.Collections.Generic;
using System.Text;

namespace SPN.Auto.Services.Mapping.MappingProfiles
{
    public class AutomobileConfiguration:Profile
    {
        public AutomobileConfiguration()
        {
            this.CreateMap<MainCreateInputModel, Automobile>();
        }
    }
}
