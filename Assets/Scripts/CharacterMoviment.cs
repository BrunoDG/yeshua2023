using UnityEngine;

public class CharacterMoviment : MonoBehaviour
{
    [SerializeField] private float speed;
    public static bool characterMoviment;
    public static Vector2 moviment;
    private Rigidbody2D rb2;
    public float distanceRay;
    public LayerMask layer;
    [SerializeField] private KeyCode interactKey = KeyCode.E;
    
  
   
    
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
        characterMoviment = true;

    }
    public void MovementAxis()
    {
        moviment = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        
        rb2.velocity = new Vector2(moviment.x * speed, moviment.y * speed); // new
    }

    private void Update()
    {
        
        Interact();
       
        
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

    public void Interact()
    {
         RaycastHit2D hitInfo = Physics2D.Raycast(transform.position,transform.right,distanceRay,layer);

         if (Input.GetKeyDown(interactKey)&& hitInfo)
         {
            
            IInteractable obj = hitInfo.transform.GetComponent<IInteractable>();
             if (obj == null) return;

             obj.Interact();
         }
       
    }
    

}
