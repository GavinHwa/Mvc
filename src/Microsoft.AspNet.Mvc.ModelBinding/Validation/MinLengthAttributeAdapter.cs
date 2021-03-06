// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Microsoft.AspNet.Mvc.ModelBinding
{
    public class MinLengthAttributeAdapter : DataAnnotationsModelValidator<MinLengthAttribute>
    {
        public MinLengthAttributeAdapter(MinLengthAttribute attribute)
            : base(attribute)
        {
        }

        public override IEnumerable<ModelClientValidationRule> GetClientValidationRules(
            [NotNull] ClientModelValidationContext context)
        {
            var message = GetErrorMessage(context.ModelMetadata);
            return new[] { new ModelClientValidationMinLengthRule(message, Attribute.Length) };
        }
    }
}
