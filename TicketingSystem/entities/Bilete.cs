using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketingSystem.entities
{
    class Bilete
    {
        private int id;
        private int rand;
        private int numar;
        private bool stare;
        private int spectacolId;

        public Bilete(int id, int rand, int numar, bool stare, int spectacolId)
        {
            this.id = id;
            this.rand = rand;
            this.numar = numar;
            this.stare = stare;
            this.spectacolId = spectacolId;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Rand
        {
            get { return rand; }
            set { rand = value; }
        }

        public int Numar
        {
            get { return numar; }
            set { numar = value; }
        }

        public bool Stare
        {
            get { return stare; }
            set { stare = value; }
        }

        public int SpectacolId
        {
            get { return spectacolId; }
            set { spectacolId = value; }
        }
    }
}
