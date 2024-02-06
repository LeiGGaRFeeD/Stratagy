using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;

public class AttackPerformer : MonoBehaviour
{
    public Animator animator; // ������ �� ��������� Animator ���������

    public Character character;
    public Button meleeButton;
    public Button rangedButton;
    public Button magicButton;

    private void Start()
    {
        // ��������� ������ ��� ������
        meleeButton.onClick.AddListener(() => character.SetStrategy(new MeleeAttackStrategy()));
        rangedButton.onClick.AddListener(() => character.SetStrategy(new RangedAttackStrategy()));
        magicButton.onClick.AddListener(() => character.SetStrategy(new MagicAttackStrategy()));
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            character.PerformAttack();
        }
    }

    // ������ ��� ������ �������� ����
    public void PerformMeleeAttack()
    {
        animator.SetTrigger("MeleeAttack");
    }

    public void PerformRangedAttack()
    {
        animator.SetTrigger("RangedAttack");
    }

    public void PerformMagicAttack()
    {
        animator.SetTrigger("MagicAttack");
    }

    // ������ ������, ������� ���������� ��� ������� ������
    public void OnAttackButtonPressed(int attackType)
    {
        switch (attackType)
        {
            case 0:
                PerformMeleeAttack();
                break;
            case 1:
                PerformRangedAttack();
                break;
            case 2:
                PerformMagicAttack();
                break;
        }
    }

}