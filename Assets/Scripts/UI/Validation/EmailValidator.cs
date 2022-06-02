using System.Text.RegularExpressions;

using UnityEngine;

namespace AdsSdk.UI.Validation
{
    public class EmailValidator : EmptyFieldValidator
    {
        public override bool IsValid()
        {
            if ((!base.IsValid()))
                return false;

            string regexPattern =
            @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
            + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
            + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
            + @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})$";
            Match matches = Regex.Match(InputField.text, regexPattern);
            if (matches.Success)
            {
                return true;
            }

            Debug.LogError("The email address is badly formatted.");
            return false;
        }
    }
}