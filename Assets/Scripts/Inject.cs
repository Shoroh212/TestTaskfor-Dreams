using UnityEngine;
using VContainer;
using VContainer.Unity;

public class Inject : LifetimeScope
{
    [SerializeField] private int startMoney = 100;

    protected override void Configure(IContainerBuilder builder)
    {
        builder.Register<IMoneyManager>(
            _ => new MoneyManager(startMoney),
            Lifetime.Singleton);

        builder.RegisterComponentInHierarchy<Machine>();
    }
}