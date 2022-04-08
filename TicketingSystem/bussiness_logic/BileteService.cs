using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.data_layer;
using TicketingSystem.entities;

namespace TicketingSystem.bussiness_logic
{
    class BileteService
    {
        private BileteDAL bileteDAL = new BileteDAL();
        private SpectacoleDAL spectacoleDAL = new SpectacoleDAL();

        public bool existaBilet(int rand, int numar, String titlu)
        {
            Spectacole s = spectacoleDAL.getSpectacol(titlu);
            List<Bilete> bilete = bileteDAL.getBilete(s.Id);
            foreach (Bilete b in bilete)
            {
                if (b.Rand == rand && b.Numar == numar)
                    return true;
            }
            return false;
        }

        public void addBilet(int rand, int numar, String titlu) 
        {
            Exception nou = null;
            try
            { 
                Spectacole s = spectacoleDAL.getSpectacol(titlu);
                if (s.NrBilete > bileteDAL.nbBileteSpectacol(s.Id))
                {
                    if (!existaBilet(rand, numar, titlu))
                    {
                        bileteDAL.addBilet(rand, numar, false, s.Id);
                    }
                    else
                    {
                        nou = new Exception("Acest loc este deja introdus pentru acest spectacolul");
                        throw nou;
                    }
                }
                else
                {
                    nou = new Exception("Nu mai sunt bilete disponibile pentru acest spectacol");
                    throw nou;
                }
                
            }
            catch (Exception e) when (nou == null)
            {
                throw new Exception("A aparut o eroare la adaugarea biletului", e);
            }
            
        }

        public void deleteBilete(int id)
        {
            try { 
                bileteDAL.deleteBilete(id);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void sellBilet(String titlu, int rand, int numar)
        {
            Exception nou = null;
            try
            {
                int spectacolId = spectacoleDAL.getSpectacol(titlu).Id;
                if (existaBilet(rand, numar, titlu))
                {
                    Bilete b = bileteDAL.getBilet(numar, rand, spectacolId);
                    if (!b.Stare)
                    {
                        bileteDAL.updateBilet(b.Id, b.Rand, b.Numar, true, b.SpectacolId);
                    }
                    else
                    {
                        nou = new Exception("Acest bilet este deja vandut");
                        throw nou;
                    }
                }
                else
                {
                    nou = new Exception("Acest loc nu exista pentru spectacolul dorit");
                    throw nou;
                }

            }
            catch (Exception e) when (nou == null)
            {
                throw new Exception("A aparut o eroare la vinzarea biletului", e);
            }
        }

        public DataTable getTabelBilete()
        {
            try
            {
                return bileteDAL.getTabelBilete();
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public DataTable getTableBileteSpectacol(String titlu)
        {
            try
            {
                return bileteDAL.getTableBileteSpectacol(spectacoleDAL.getSpectacol(titlu).Id);
            }
            catch(Exception e)
            {
                throw e;
            }
            
        }
    }
}
