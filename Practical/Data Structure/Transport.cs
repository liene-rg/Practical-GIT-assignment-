using System;

namespace Data_Structure
{
    abstract class Transport
    {
        protected int wheels, speed;
        protected bool moving = true;
        abstract public void Move(int age);


        abstract public void SpeedUp();

        public void SpeedDown()
        {
            if (this.speed >= 0)
            this.speed--;
                Console.WriteLine("Current speed is " + this.speed);
            if (this.speed < 0)
                moving = !moving;
        }


    }
}
