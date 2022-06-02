using System.Text.RegularExpressions;
using UnityEngine;

namespace AdsSdk.UI.Validation
{
    public class CardNumberValidator : EmptyFieldValidator
    {
        public override bool IsValid()
        {
            if (!base.IsValid())
            {
                return false;
            }

            string regexPattern = @"^[1-9][0-9]{15}$";
            Match matches = Regex.Match(InputField.text, regexPattern);
            if (matches.Success)
            {
                return true;
            }

            Debug.LogError("Card number must constain 16 digits and can not start with 0");
            return false;
        }
    }
}