using System.Collections.Generic;
using Unit06.Game.Casting;
using Unit06.Game.Services;


namespace Unit06.Game.Scripting
{
    public class CheckOverAction : Action
    {
        public CheckOverAction()
        {
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            //added the following line and commented the next
            Stats stats = (Stats)cast.GetFirstActor(Constants.STATS_GROUP);
            //List<Actor> bricks = cast.GetActors(Constants.BRICK_GROUP);
            //if (bricks.Count == 0)
            if (stats.GetScore() == 15)
            {
                //Stats stats = (Stats)cast.GetFirstActor(Constants.STATS_GROUP);
                stats.AddLevel();
                callback.OnNext(Constants.NEXT_LEVEL);
            }
        }
    }
}