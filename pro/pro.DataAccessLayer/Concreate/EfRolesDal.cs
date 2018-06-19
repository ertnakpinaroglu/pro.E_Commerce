﻿using pro.CoreLayer.GenericRepository;
using pro.DataAccessLayer.Abstract;
using pro.EntitiesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace pro.DataAccessLayer.Concreate
{
    public class EfRolesDal : GenericRepo<Roles>, IRolesDal
    {
        public EfRolesDal(DbContext context) : base(context)
        {
        }
    }
}