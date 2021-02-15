﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //T  data: kullanıcı buraya her tip data atabilir
    public interface IDataResult<T>:IResult
    {
        T Data { get; }
    }
}
