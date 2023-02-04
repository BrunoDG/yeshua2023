using UnityEngine;

public class AnimationCharacter : MonoBehaviour
{
    public Animator animationCharacter;

    // Update is called once per frame
    void Update()
    {
        AnimationCharacter2D();
    }
    public void AnimationCharacter2D()
    {
            animationCharacter.SetFloat("Horizontal",CharacterMoviment.moviment.x);
            animationCharacter.SetFloat("Vertical", CharacterMoviment.moviment.y);
            animationCharacter.SetFloat("Speed", CharacterMoviment.moviment.magnitude);
    }
}
