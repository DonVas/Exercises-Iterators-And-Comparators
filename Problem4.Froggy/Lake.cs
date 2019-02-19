using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem4.Froggy
{
    public class Lake :IEnumerable<int>
    {
        private List<int> stons;

        public Lake(params int[] stonse)
        {
            this.stons = stonse.ToList();
        }
        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < stons.Count; i+=2)
            {
                yield return this.stons[i];
            }

            int revIndex = this.stons.Count % 2 == 0
                ? this.stons.Count - 1
                : this.stons.Count - 2;

            for (int i = revIndex; i >= 0 ; i -= 2)
            {
                yield return this.stons[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
