﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface ITaxaJurosService
    {
        Task Get();
        double GetIdc();
    }
}
