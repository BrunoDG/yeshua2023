using UnityEngine;

public class CharacterMoviment : MonoBehaviour
{
    [SerializeField] private float speed;
 
    public static bool characterMoviment;
    public static Vector2 moviment;
    private Rigidbody2D rb2;
  
   
    
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
        characterMoviment = true;

    }
    public void MovementAxis()
    {
        moviment = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        //rb2.position = rb2.position + moviment * speed; // antigo
        rb2.velocity = new Vector2(moviment.x * speed, moviment.y * speed); // new
    }

    private void Update()
    {
        
        
        
    }
     private void FixedUpdate()
    {
        if (characterMoviment)
        {
            MovementAxis();
        }

     }

      private  void SetSpeed( float speedSet)
      {
            
      }
    

}
