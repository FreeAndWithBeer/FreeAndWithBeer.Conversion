﻿namespace FreeAndWithBeer.Conversion
{
    using System;

    public class ConvertTypeRequest
    {
        internal ConvertTypeRequest(object value, Type conversionType, IFormatProvider provider)
        {
            Value = value;
            ConversionType = conversionType;
            Provider = provider;
        }

        public object Value { get; private set; }
        public Type ConversionType { get; private set; }
        public IFormatProvider Provider { get; }

        public bool ConversionTypeAllowsNull => !ConversionType.IsValueType || ConversionType.IsGenericNullable();

        public bool IsConverted { get; private set; }
        public object ConvertedValue { get; private set; }

        public void Converted(object convertedValue)
        {
            IsConverted = true;
            ConvertedValue = convertedValue;
        }
    }
}