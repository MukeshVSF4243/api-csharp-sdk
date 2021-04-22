namespace BoldSign.Api
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using BoldSign.Model;

    internal static class FromRequestHelper
    {
        public static Dictionary<string, string> ConvertToFormRequest(SendForSign signRequestDetails, Dictionary<string, string> localVarFormParams)
        {
            if (signRequestDetails.Title != null)
            {
                localVarFormParams.Add(nameof(signRequestDetails.Title), signRequestDetails.Title);
            }

            string expiryDays = signRequestDetails.ExpiryDays > 0 ? signRequestDetails.ExpiryDays.ToString() : "60";

            localVarFormParams.Add(nameof(signRequestDetails.ExpiryDays), expiryDays);

            if (signRequestDetails.Message != null)
            {
                localVarFormParams.Add(nameof(signRequestDetails.Message), signRequestDetails.Message);
            }

            if (signRequestDetails.Signers != null)
            {
                localVarFormParams = ToFormParameter(localVarFormParams, signRequestDetails.Signers.ToList(), nameof(signRequestDetails.Signers));
            }

            if (signRequestDetails.CC != null)
            {
                localVarFormParams = ToFormParameter(localVarFormParams, signRequestDetails.CC.ToList(), nameof(signRequestDetails.CC));
            }

            if (signRequestDetails.BrandId != null)
            {
                localVarFormParams.Add(nameof(signRequestDetails.BrandId), signRequestDetails.BrandId);
            }
            
            if (signRequestDetails.ReminderSettings != null)
            {
                localVarFormParams.Add($"{nameof(signRequestDetails.ReminderSettings)}.{nameof(signRequestDetails.ReminderSettings.EnableAutoReminder)}", signRequestDetails.ReminderSettings.EnableAutoReminder.ToString());
                localVarFormParams.Add($"{nameof(signRequestDetails.ReminderSettings)}.{nameof(signRequestDetails.ReminderSettings.ReminderDays)}", signRequestDetails.ReminderSettings.ReminderDays.ToString());
                localVarFormParams.Add($"{nameof(signRequestDetails.ReminderSettings)}.{nameof(signRequestDetails.ReminderSettings.ReminderCount)}", signRequestDetails.ReminderSettings.ReminderCount.ToString());
            }

            localVarFormParams.Add(nameof(signRequestDetails.EnableSigningOrder), signRequestDetails.EnableSigningOrder ? "true" : "false");
            localVarFormParams.Add(nameof(signRequestDetails.EnableEmbeddedSigning), signRequestDetails.EnableEmbeddedSigning ? "true" : "false");

            return localVarFormParams;
        }

        private static Dictionary<string, string> ToFormParameter(Dictionary<string, string> localVarFormParams, object property, string parameterName)
        {
            switch (property)
            {
                case null:
                    return localVarFormParams;
                case IEnumerable enumerable:
                    {
                        var i = -1;

                        foreach (var item in enumerable)
                        {
                            ToFormParameter(localVarFormParams, item, $"{parameterName}[{++i}]");
                        }

                        return localVarFormParams;
                    }
            }

            var props = property.GetType().GetProperties();

            foreach (var prop in props)
            {
                var value = prop.GetValue(property, new object[] { });

                if (value == null)
                {
                    continue;
                }

                var name = $"{parameterName}[{prop.Name}]";

                if (value is Enum)
                {
                    var enumType = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType;

                    var enumValues = Enum.GetValues(enumType);

                    if (enumValues.Cast<object>().Any(enumValue => Convert.ToInt32(value).ToString() == Convert.ToInt32(enumValue).ToString()))
                    {
                        localVarFormParams.Add(name, value.ToString());
                    }
                }
                else if (value is string || prop.PropertyType.IsPrimitive)
                {
                    localVarFormParams.Add(name, value.ToString());
                }
                else if (value is IEnumerable)
                {
                    ToFormParameter(localVarFormParams, value, name);
                }
                else if (prop.PropertyType.IsClass)
                {
                    ToFormParameter(localVarFormParams, value, name);
                }
            }

            return localVarFormParams;
        }
    }
}
