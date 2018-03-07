using System;
namespace MonoGame
{
    /// <summary>
    /// Dobbelstenen spel met meerdere dobbelstenen
    /// Sytse Durkstra 29/10/2008
    /// </summary>
    class dobbelstenen
    {
        Random random = new Random();
        public int[] Worp()
        {
            int[] worpen = new int[2];
            worpen[0] = EnkeleWorp();
            worpen[1] = EnkeleWorp();

            return worpen;
        }

        private int EnkeleWorp()
        {
            int value = (int)(random.NextDouble() * 6) + 1;
            Console.WriteLine(value);
            return value;
            
        }
    

    }//end class
}//end namespace