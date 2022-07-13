using Unit06.Game.Casting;

namespace Unit06.Game.Scripting
{
    public class MoveRacketAction : Action
    {
        public MoveRacketAction()
        {
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            Racket racket = (Racket)cast.GetFirstActor(Constants.RACKET_GROUP);
            Body body = racket.GetBody();
            Point position = body.GetPosition();
            Point velocity = body.GetVelocity();
            int x = position.GetX();

            position = position.Add(velocity);
            if (x < 0)
            {
                position = new Point(0, position.GetY());
            }
            else if (x > Constants.SCREEN_WIDTH - Constants.RACKET_WIDTH)
            {
                position = new Point(Constants.SCREEN_WIDTH - Constants.RACKET_WIDTH, 
                    position.GetY());
            }

            body.SetPosition(position);    

            Racket racket2 = (Racket)cast.GetSecondActor(Constants.RACKET_GROUP);
            Body body2 = racket2.GetBody();
            Point position2 = body2.GetPosition();
            Point velocity2 = body2.GetVelocity();
            int x2 = position2.GetX();

            position2 = position2.Add(velocity2);
            if (x2 < 0)
            {
                position2 = new Point(0, position2.GetY());
            }
            else if (x2 > Constants.SCREEN_WIDTH - Constants.RACKET_WIDTH)
            {
                position2 = new Point(Constants.SCREEN_WIDTH - Constants.RACKET_WIDTH, 
                    position2.GetY());
            }

            body2.SetPosition(position2);  
        }
    }
}