using UnityEngine;
using UnityEngine.UI;

namespace AdsSdk.UI.Validation
{
    [RequireComponent(typeof(InputField))]
    public abstract class FieldValidator : MonoBehaviour
    {
        public InputField InputField { get; private set; }

        private void Awake()
        {
            InputField = GetComponent<InputField>();
        }

        public abstract bool IsValid();
    }
}