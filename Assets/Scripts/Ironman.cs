using UnityEngine;

public class Ironman : MonoBehaviour
{

    public Animator IronmanAnimator;

    public void Box()
    {
        IronmanAnimator.SetTrigger("Box");

    }

    public void Kick()
    {
        IronmanAnimator.SetTrigger("Kick");

    }
}
