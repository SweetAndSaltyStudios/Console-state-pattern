namespace ConsoleStatePattern.States
{
    class BarState : IState
    {
        public void EnterState(Player player)
        {
            player.StateEvent("Bar", -100);
        }

        //public void Exit(Player player)
        //{
        //    // If pressing Up
        //    // Do nothing

        //    // If pressing Right
        //    // player.ChangeState(new HomeState());

        //    // If pressing Left
        //    // Do nothing

        //    // If pressing Down
        //    // Do nothing
        //}
    }
}
