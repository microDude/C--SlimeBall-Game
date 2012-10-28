using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SlimeBall
{
    /// <summary>
    /// Summary for Score.
    /// </summary>
    class Score
    {
        private int count;          //total number of slimes
        private int[] scores;       //score for each individual slime

        /// <summary>
        /// 
        /// </summary>
        public Score()
        {
            scores = null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n"n></param>
        public Score(int n)
        {
            count = n;
            scores = new int[n];
            Array.Clear(scores, 0, n - 1);
        }

        public int GetScore(int n)
        {
            return scores[n];       
        }

        public void SetScore(int n, int x)
        {
            scores[n]=x;
        } 

        public int[] GetScores()
        {
            return scores;
        }

        //the increasement is variable x. To design slime tennis, make x = 15
        public void AddScore(int n, int x)
        {
            scores[n] += x;
        }

        public void ResetScores()
        {
            for (int i = 0; i < count; i++)
                scores[i] = 0;
        }

    }
}
