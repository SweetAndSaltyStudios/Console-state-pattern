using ConsoleStatePattern.States;
using System;

namespace ConsoleStatePattern
{
    public class Player
    {
        private IState currentState;
       
        private string place = "Home";
        private int money = 300;

        public IState CurrentState { get { return currentState; } }

        public string Place { get { return place; } }
        public int Money { get { return money; } }
      
        // Constructor
        public Player(IState startState)
        {
            currentState = startState;
        }

        public void StateEvent(string place, int amount)
        {
            this.place = place;
            money += amount;
        }

        public void Move()
        {
            while (true)
            {
                // Do switch statement...

                ConsoleKeyInfo cki = Console.ReadKey(true);

                if (cki.Key == ConsoleKey.Enter)
                {
                    Environment.Exit(0);
                }

                if (place == "Home")
                {
                    if (cki.Key == ConsoleKey.UpArrow)
                    {
                        ChangeState(new JobState());
                        ConsoleInput();
                    }
                    else if (cki.Key == ConsoleKey.RightArrow)
                    {
                        ChangeState(new StoreState());
                        ConsoleInput();
                    }
                    else if (cki.Key == ConsoleKey.LeftArrow)
                    {
                        ChangeState(new BarState());
                        ConsoleInput();
                    }
                    else if (cki.Key == ConsoleKey.DownArrow)
                    {

                    }
                }
                else if (place == "Job")
                {
                    if (cki.Key == ConsoleKey.UpArrow)
                    {

                    }
                    else if (cki.Key == ConsoleKey.RightArrow)
                    {

                    }
                    else if (cki.Key == ConsoleKey.LeftArrow)
                    {

                    }
                    else if (cki.Key == ConsoleKey.DownArrow)
                    {
                        ChangeState(new HomeState());
                        ConsoleInput();
                    }
                }
                else if (place == "Store")
                {
                    if (cki.Key == ConsoleKey.UpArrow)
                    {

                    }
                    else if (cki.Key == ConsoleKey.RightArrow)
                    {

                    }
                    else if (cki.Key == ConsoleKey.LeftArrow)
                    {
                        ChangeState(new HomeState());
                        ConsoleInput();
                    }
                    else if (cki.Key == ConsoleKey.DownArrow)
                    {

                    }
                }
                else if (place == "Bar")
                {
                    if (cki.Key == ConsoleKey.UpArrow)
                    {

                    }
                    else if (cki.Key == ConsoleKey.RightArrow)
                    {
                        ChangeState(new HomeState());
                        ConsoleInput();
                    }
                    else if (cki.Key == ConsoleKey.LeftArrow)
                    {

                    }
                    else if (cki.Key == ConsoleKey.DownArrow)
                    {

                    }
                }
            }
        } 
       
        public void ChangeState(IState newState)
        {
            //if (currentState != null)
            //{
            //    currentState.Exit(this);
            //}

            currentState = newState;

            currentState.EnterState(this);
        }

        public void ConsoleInput()
        {
            // We hide annoyingly flashing cursor ...
            Console.CursorVisible = false;
            // Clear the console so it's maybe easier to read and follow ...
            Console.Clear();

            Console.WriteLine(" ");
            Console.WriteLine(" Place: " + Place);
            Console.WriteLine(" Money: " + Money);
            Console.WriteLine(" Current state: " + CurrentState);
            Console.WriteLine(" ");
            Console.WriteLine(" Use 'arrow' keys to change states.");
            Console.Write(" Press 'Enter' to quit the game.");
        }
    }
}
