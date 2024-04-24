
public abstract class GMBaseState
{
    public abstract void OnEnterState(GameManager manager);
    public abstract void OnUpdateState(GameManager manager);
    public abstract void OnExitState(GameManager manager);

}
public class InitState : GMBaseState
{
    public override void OnEnterState(GameManager manager)
    {
        manager.InitStateOnEnterState();
    }

    public override void OnExitState(GameManager manager)
    {
        manager.InitStateOnExitState();
    }

    public override void OnUpdateState(GameManager manager)
    {
        manager.InitStateOnUpdateState();
    }
}
public class LoadDataState : GMBaseState
{
    public override void OnEnterState(GameManager manager)
    {
        manager.DataLoadStateOnEnterState();
    }

    public override void OnExitState(GameManager manager)
    {
        manager.DataLoadStateOnExitState();
    }

    public override void OnUpdateState(GameManager manager)
    {
        manager.DataLoadStateOnUpdateState();
    }
}