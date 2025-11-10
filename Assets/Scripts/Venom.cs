using UnityEngine;

public class Venom : MonoBehaviour
{
   public Animator VenomAnimator;

    public void Box()
    {
        VenomAnimator.SetTrigger("Box");

    }

    public void Kick()
    {
        VenomAnimator.SetTrigger("Kick");

    }
}
