﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetAll();
        IDataResult<List<Rental>> GetById(int id);
        IDataResult<List<RentalDetailDto>> GetRentalDetail();
        IResult Update(Rental rental);
        IResult Delete(Rental rental);
        IResult Add(Rental rental);

    }

}
