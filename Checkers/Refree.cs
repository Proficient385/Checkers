using System;
using System.Collections.Generic;
using System.Text;

namespace Checkers
{
    class Refree : IReferee
    {
        public bool IsDraw()
        {
            throw new NotImplementedException();
        }

        public void Play()
        {
            throw new NotImplementedException();
        }

        public IPlayer Winner()
        {
            throw new NotImplementedException();
        }
    }
}
