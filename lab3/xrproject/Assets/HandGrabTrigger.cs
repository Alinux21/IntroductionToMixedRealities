using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class HandGrabAnimation : MonoBehaviour
{
    public Animator handAnimator;
    public XRGrabInteractable grabInteractable;

    private void OnEnable()
    {
        grabInteractable.selectEntered.AddListener(OnGrab);
        grabInteractable.selectExited.AddListener(OnRelease);
    }

    private void OnDisable()
    {
        grabInteractable.selectEntered.RemoveListener(OnGrab);
        grabInteractable.selectExited.RemoveListener(OnRelease);
    }

    private void OnGrab(SelectEnterEventArgs args)
    {
        handAnimator.SetTrigger("GrabTrigger");
    }

    private void OnRelease(SelectExitEventArgs args)
    {
        handAnimator.ResetTrigger("GrabTrigger"); //reset or trigger release animation
    }
}
