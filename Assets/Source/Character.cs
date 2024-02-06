using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public interface IAttackStrategy
{
    void Attack();
}
public class Character
{
    private IAttackStrategy _currentStrategy;

    public void SetStrategy(IAttackStrategy strategy)
    {
        _currentStrategy = strategy;
    }

    public void PerformAttack()
    {
        if (_currentStrategy != null)
        {
            _currentStrategy.Attack();
        }
    }
}