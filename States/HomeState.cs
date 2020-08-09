namespace ConsoleStatePattern.States
{
    public class HomeState : IState
    {
        public void EnterState(Player player)
        {
            player.StateEvent("Home", 0);
        }

        //public void Exit(Player player)
        //{
        //    // If pressing Up
        //    // player.ChangeState(new Job());

        //    // If pressing Right
        //    // player.ChangeState(new Store());

        //    // If pressing Left
        //    // player.ChangeState(new Bar());

        //    // If pressing Down
        //    // Do nothing
        //}
    }
}
