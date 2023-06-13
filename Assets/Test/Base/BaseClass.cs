using FishNet.Object;
using FishNet.Object.Synchronizing;

// In an Assembly
public class BaseClass : NetworkBehaviour
{
    [SyncVar]
    private float Sync_baseTest;

    public override void OnStartServer()
    {
        base.OnStartServer();
        TimeManager.OnTick += Tick;
    }

    private void Tick()
    {
        Sync_baseTest++;
    }
}
