using UnityEngine;

namespace AdsSdk.UI.Validation
{
    public class EmptyFieldValidator : FieldValidator
    {
        public override bool IsValid()
        {
            if (string.IsNullOrEmpty(InputField.text))
            {
                Debug.LogError($"{InputField.name} can not be empty.");
                return false;
            }

            return true;
        }
    }
}