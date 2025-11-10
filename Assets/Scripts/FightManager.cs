using UnityEngine;

public class FightManager : MonoBehaviour
{
    public Animator hulkAnimator;
    
    public void Box()
    {
        hulkAnimator.SetTrigger("Box");
       
    }

    public void Kick()
    {
        hulkAnimator.SetTrigger("Kick");
       
    }
}
