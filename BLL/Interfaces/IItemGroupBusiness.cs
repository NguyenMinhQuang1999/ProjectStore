﻿using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
namespace BLL
{
    public partial interface IItemGroupBusiness
    {
        List<ItemGroupModel> GetData();
    }

}