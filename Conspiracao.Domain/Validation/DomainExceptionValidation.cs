﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conspiracao.Domain.Validation
{
    public class DomainExceptionValidation : Exception
    {
        public DomainExceptionValidation(string error) : base(error)
        {

        }
        public static void When(bool hasError, string erro)
        {
            if (hasError)
                throw new DomainExceptionValidation(erro);
        }
    }
}
