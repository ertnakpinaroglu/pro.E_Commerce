﻿using pro.DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro.DataAccessLayer.UnitOfWork.Abstract
{
    public interface IUnitOfWork : IDisposable
    {

        IBasketDal BasketDal { get; }
        IBuyDal BuyDal { get; }
        ICategoryDal CategoryDal { get; }
        IColorsDal ColorsDal { get; }
        ICustomerDal CustomerDal { get; }
        IFavsDal FavsDal { get; }
        IImagesDal ImagesDal { get; }
        IProductDal ProductDal { get; }
        IProductSizeColorDal ProductSizeColorDal { get; }

        IRolesDal RolesDal { get; }

        ISizeDal SizeDal { get; }

        ISubCategoryDal SubCategoryDal { get; }

        IBrandDal BrandDal { get; }

        int Complete();


    }
}
