// Copyright (c) Microsoft Open Technologies, Inc.
// All Rights Reserved
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// THIS CODE IS PROVIDED *AS IS* BASIS, WITHOUT WARRANTIES OR
// CONDITIONS OF ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING
// WITHOUT LIMITATION ANY IMPLIED WARRANTIES OR CONDITIONS OF
// TITLE, FITNESS FOR A PARTICULAR PURPOSE, MERCHANTABLITY OR
// NON-INFRINGEMENT.
// See the Apache 2 License for the specific language governing
// permissions and limitations under the License.

using System;
using Microsoft.AspNet.Razor.Generator;
using Microsoft.AspNet.Razor.Parser.SyntaxTree;

namespace Microsoft.AspNet.Mvc.Razor
{
    public class InjectParameterGenerator : SpanCodeGenerator
    {
        public InjectParameterGenerator(string baseType)
        {
            BaseType = baseType;
        }

        public string BaseType { get; private set; }

        public override void GenerateCode(Span target, CodeGeneratorContext context)
        {
            context.CodeTreeBuilder.AddSetBaseTypeChunk(BaseType, target);
        }

        public override string ToString()
        {
            return "Base:" + BaseType;
        }

        public override bool Equals(object obj)
        {
            SetBaseTypeCodeGenerator other = obj as SetBaseTypeCodeGenerator;
            return other != null &&
                   String.Equals(BaseType, other.BaseType, StringComparison.Ordinal);
        }

        public override int GetHashCode()
        {
            return BaseType.GetHashCode();
        }
    }
}