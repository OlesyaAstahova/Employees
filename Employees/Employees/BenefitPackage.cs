﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    public class BenefitPackage
    {
        public double ComputePayDeduction() { return 125.0; }
        public enum BenefitPackageLevel
        {
            Standard, Gold, Platinum
        }
    }

}
