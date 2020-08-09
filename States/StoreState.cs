namespace ConsoleStatePattern.States
{
    class StoreState : IState
    {
        public void EnterState(Player player)
        {
            player.StateEvent("Store", -50);
        }

        //public void Exit(Player player)
        //{
        //    // If pressing Up
        //    // Do nothing

        //    // If pressing Right
        //    // Do nothing

        //    // If pressing Left
        //    // player.ChangeState(new HomeState());

        //    // If pressing Down
        //    // Do nothing
        //}
    }
}
