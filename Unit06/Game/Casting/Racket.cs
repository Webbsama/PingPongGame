namespace Unit06.Game.Casting
{
    /// <summary>
    /// A thing that participates in the game.
    /// </summary>
    public class Racket : Actor
    {
        private Body body;
        private Animation animation;
        
        /// <summary>
        /// Constructs a new instance of Actor.
        /// </summary>
        public Racket(Body body, Animation animation, bool debug) : base(debug)
        {
            this.body = body;
            this.animation = animation;
        }

        /// <summary>
        /// Gets the animation.
        /// </summary>
        /// <returns>The animation.</returns>
        public Animation GetAnimation()
        {
            return animation;
        }

        /// <summary>
        /// Gets the body.
        /// </summary>
        /// <returns>The body.</returns>
        public Body GetBody()
        {
            return body;
        }

        /// <summary>
        /// Moves the racket to its next position.
        /// </summary>
        public void MoveNext()
        {
            Point position = body.GetPosition();
            Point velocity = body.GetVelocity();
            Point newPosition = position.Add(velocity);
            body.SetPosition(newPosition);
        }

        /// <summary>
        /// Swings the racket to the left.
        /// </summary>
        public void SwingUp()
        {
            Point velocity = new Point(0, -Constants.RACKET_VELOCITY);
            body.SetVelocity(velocity);
        }

        /// <summary>
        /// Swings the racket to the right.
        /// </summary>
        public void SwingDown()
        {
            Point velocity = new Point(0, Constants.RACKET_VELOCITY);
            body.SetVelocity(velocity);
        }

        /// <summary>
        /// Stops the racket from moving.
        /// </summary>
        public void StopMoving()
        {
            Point velocity = new Point(0, 0);
            body.SetVelocity(velocity);
        }
        
    }
}