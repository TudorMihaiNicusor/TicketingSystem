using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketingSystem.entities
{
    class Spectacole
    {
        private int id;
        private String titlu;
        private String regizor;
        private String actori;
        private String data;
        private int nrBilete;
        public Spectacole(int id, String titlu, String regizor, String actori, String data, int nrBilete)
        {
            this.id = id;
            this.titlu = titlu;
            this.regizor = regizor;
            this.actori = actori;
            this.data = data;
            this.nrBilete = nrBilete;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public String Titlu
        {
            get { return titlu; }
            set { titlu = value; }
        }

        public String Regizor
        {
            get { return regizor; }
            set { regizor = value; }
        }

        public String Actori
        {
            get { return actori; }
            set { actori = value; }
        }

        public String Data
        {
            get { return data; }
            set { data = value; }
        }

        public int NrBilete
        {
            get { return nrBilete; }
            set { nrBilete = value; }
        }
    }
}
