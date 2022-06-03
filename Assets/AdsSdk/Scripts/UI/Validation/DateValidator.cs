using System;
using System.Globalization;

using UnityEngine;

namespace AdsSdk.UI.Validation
{
    public class DateValidator : EmptyFieldValidator
    {
        [SerializeField] private string _dateFormat;

        public string DateFormat => _dateFormat;

        public override bool IsValid()
        {
            if (!base.IsValid())
            {
                return false;
            }

            if (DateTime.TryParseExact(InputField.text, _dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime result))
            {
                return true;
            }

            Debug.LogError($"Data must be inputed in {_dateFormat} format");
            return false;
        }
    }
}

