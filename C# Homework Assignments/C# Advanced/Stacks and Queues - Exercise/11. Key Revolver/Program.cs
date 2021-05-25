using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Key_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int gunBarrelSize = int.Parse(Console.ReadLine());
            int[] bullets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] locks = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int intelligence = int.Parse(Console.ReadLine());

            Queue<int> locksQueue = new Queue<int>();

            foreach (var currentLock in locks)
            {
                locksQueue.Enqueue(currentLock);
            }

            Stack<int> bulletsStack = new Stack<int>(bullets);

            foreach (var currentBullet in bullets)
            {
                bulletsStack.Push(currentBullet);
            }

            while (true)
            {
                int bulletToShoot = bulletsStack.Pop();

                if (bulletToShoot >= locksQueue.Peek())
                {
                    Console.WriteLine("Bang!");
                    locksQueue.Dequeue();
                }
                else if (bulletToShoot < locksQueue.Peek())
                {
                    Console.WriteLine("Ping!");
                }
                gunBarrelSize--;
                if ( )
                {

                }
            }
        }
    }
}
