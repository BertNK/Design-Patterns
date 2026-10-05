using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class Projector
    {
        private DvdPlayer _dvdPlayer;
        public Projector()
        {
        }

        public void SetInput(DvdPlayer dvdPlayer)
        {
            this._dvdPlayer = dvdPlayer;
            Console.WriteLine("Projector input set to DVD player");
        }

        public void On()
        {
            Console.WriteLine("Projector on");
        }

        public void Off()
        {
            Console.WriteLine("Projector off");
        }

        public void TvMode()
        {
            Console.WriteLine("Projector set to TV mode");
        }

        public void WideScreenMode()
        {
            Console.WriteLine("Projector set to widescreen mode");
        }
    }
}
