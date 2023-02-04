using System.Collections;
using UnityEngine;
using UnityEngine.UI;



public abstract class LifeBase : MonoBehaviour
{
    [SerializeField] private int life;
    [SerializeField] private float barlife;
    [SerializeField]private SpriteRenderer sprite_;
    [SerializeField] private Color damageColor;
    [SerializeField]private  bool takingDamage= false;
    [SerializeField] private float maxLifeBar;
    [SerializeField] private Image lifeBarUI;
    public float Barlife { get => barlife; set => barlife = Mathf.Clamp(value,0,maxLifeBar); }
    public SpriteRenderer Sprite_ { get => sprite_; set => sprite_ = value; }
    public int Life { get => life; set => life = value; }
    public bool TakingDamage_ { get => takingDamage; set => takingDamage = value; }
    public float MaxLifeBar { get => maxLifeBar; set => maxLifeBar = value; }

    // Damager Variable Int
    public void Damage(int damageCount)
    {
        Life -= damageCount;
        int zero = 0;
        if (Life <= zero)
        {

            // Dead!
            OnDestroy();
        }
        else
        {
            if(takingDamage)
            {
                StartCoroutine(TakingDamage());
            }
            
        }

    }
    // Damager Variable Float
    public void BarDamage(float damageCount)
    {

        Barlife -= damageCount;

        float zero= 0;
        if (Barlife <= zero)
        {
            CameraFollow2d.enableCamera = false;
            //Dead
            OnDestroy();
        }
        else
        {
            if(takingDamage)
            {
                StartCoroutine(TakingDamage());
            }
            
        }
    }
    public  void OnDestroy()
    {
        Destroy(gameObject);
    }


    
    private IEnumerator TakingDamage()
    {
        Sprite_.color = damageColor ;
        yield return new WaitForSeconds(0.1f);
        Sprite_.color = Color.white;
    }
     private void Update() {
        UpdateLifeBar();
     }
     public  void UpdateLifeBar()
     {
        lifeBarUI.fillAmount = Barlife/maxLifeBar;
     }
}
