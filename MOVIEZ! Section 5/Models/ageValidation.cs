﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MOVIEZ_.Models
{
    public class ageValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;

            if (customer.MembershipTypeId == 0 || customer.MembershipTypeId == 1)
                return ValidationResult.Success;
            if (customer.birthdate == null)
                return new ValidationResult("Birthdate is required for subscription plans.");
            var age = DateTime.Today.Year - customer.birthdate.Value.Year;

            return (age >= 18) ? ValidationResult.Success : new ValidationResult("Customer should be at least 18 years old. ");
        }
    }
}