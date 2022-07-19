using Unit06.Game.Casting;
using Unit06.Game.Services;
using Raylib_cs;


namespace Unit06.Game.Scripting
{
    public class ControlRacketAction : Action
    {
        private KeyboardService keyboardService;

        public ControlRacketAction(KeyboardService keyboardService)
        {
            this.keyboardService = keyboardService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            Racket racket = (Racket)cast.GetFirstActor(Constants.RACKET_GROUP);
            if (keyboardService.IsKeyDown(Constants.UP))
            {
                racket.SwingUp();
            }
            else if (keyboardService.IsKeyDown(Constants.DOWN))
            {
                racket.SwingDown();
            }
            else
            {
                racket.StopMoving();
            }

            Racket racket2 = (Racket)cast.GetSecondActor(Constants.RACKET_GROUP);
            if (keyboardService.IsKeyDown(Constants.UP2))
            {
                racket2.SwingUp();
            }
            else if (keyboardService.IsKeyDown(Constants.DOWN2))
            {
                racket2.SwingDown();
            }
            else
            {
                racket2.StopMoving();
            }
        }
    }
}