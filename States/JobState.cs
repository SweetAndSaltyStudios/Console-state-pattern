namespace ConsoleStatePattern.States
{
    class JobState : IState
    {
        public void EnterState(Player player)
        {
            player.StateEvent("Job", 50);
        }

        //public void Exit(Player player)
        //{
        //    // If pressing Up
        //    // Do nothing

        //    // If pressing Right
        //    // Do nothing

        //    // If pressing Left
        //    // Do nothing

        //    // If pressing Down
        //    // player.ChangeState(new HomeState());
        //}
    }
}
