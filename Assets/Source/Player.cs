using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//
public class Player : MonoBehaviour
{
    [SerializeField] Sprite[] _sprites;
    [SerializeField] SpriteRenderer _spriteRenderer;
    int numOfAttack;
    [SerializeField] Animator _animation;
    public void AttackOne()
    {
        //InvokeRepeating("AttackEnd", 0.4f, 0);
        _spriteRenderer.sprite = _sprites[3];
        InvokeRepeating("AttackEnd", 0.3f, 0);
        Debug.Log("Begin attack");
    }
    void AttackT()
    {
        _spriteRenderer.sprite = _sprites[1];
           InvokeRepeating("AttackEnd", 0.3f, 0);
        Debug.Log("Begin Second sprite");
    }
    void AttackTh()
    {
        _spriteRenderer.sprite = _sprites[2];
         InvokeRepeating("AttackEnd", 0.3f, 0);
        Debug.Log("Begin third sprite");
    }
    void AttackEnd()
    {
        _spriteRenderer.sprite = _sprites[0];
        Debug.Log("Attack ended");
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            _animation.SetTrigger("Attack");
            AttackOne();
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            _animation.SetTrigger("Run");
            AttackT();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            _animation.SetTrigger("Slide");
            AttackTh();
        }
    }
    public interface IAttack
    {
        int Attack();
    }
    public class AttackUno : IAttack
    {
        public int Attack()
        {
            return 1;
        }
    }
    public class AttackTwo : IAttack
    {
        public int Attack()
        {
            return 2;
        }
    }
    public class AttackThree : IAttack
    {
        public int Attack()
        {
            return 3;
        }
    }
   // public void Control()
  //  {

     //       public IAttack at { get; set; }
    //   public context(IAttack _a)
    // {
    //    at = _a;
    // }

}
//public IAttack at { get; set; }
    //   public context(IAttack _a)
    // {
    //    at = _a;
    // }
//

