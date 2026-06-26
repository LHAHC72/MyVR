using UnityEngine;
using UnityEngine.InputSystem;

namespace MyVR
{

    public class AnimatorHandOnInput : MonoBehaviour
    {
        #region Variables

        private Animator animator;

        public InputActionProperty pinchAnimationAction;
        public InputActionProperty gripAnimationAction;

        private string girp = "Grip";
        private string trigger = "Trigger";

        #endregion

        #region Unity Event Method

        private void Awake()
        {
            animator = GetComponent<Animator>();
        }

        private void Update()
        {
            // 인풋처리
            float triggerValue = pinchAnimationAction.action.ReadValue<float>();
            float gripValue = gripAnimationAction.action.ReadValue<float>();

            animator.SetFloat(trigger, triggerValue);
            animator.SetFloat(girp, gripValue);
        }
    }

        #endregion

    }
}