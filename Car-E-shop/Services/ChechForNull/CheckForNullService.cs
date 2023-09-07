﻿using Car_E_shop.Exceptions;
using Car_E_shop.Exceptions.ErrorMessages;
using Car_E_shop.Models;

namespace Car_E_shop.Services.ChechForNull
{
    public class CheckForNullService : ICheckNull
    {
        public bool IsNull(object entity)
        {

            return entity is not null;
        }

        public void ValidateEntity(object entity)
        {

            if (!IsNull(entity))
            {
                throw new ObjectIsNullException(Message.ObjectIsNull(entity));
            }
        }
    }
}
