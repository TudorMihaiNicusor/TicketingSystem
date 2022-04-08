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
    class SpectacoleService
    {
        private SpectacoleDAL spectacoleDAL = new SpectacoleDAL();
        private BileteDAL bileteDAL = new BileteDAL();

        public Spectacole getSpectacol(String titlu)
        {
            try
            {
                return spectacoleDAL.getSpectacol(titlu);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public Spectacole getSpectacol(int id)
        {
            try
            {
                return spectacoleDAL.getSpectacol(id);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void addSpectacol(String titlu, String regizor, String actori, String data, int nrBilete)
        {
            try
            {
                spectacoleDAL.addSpectacol(titlu, regizor, actori, data, nrBilete);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void updateSpectacol(String titlu, String regizor, String actori, String data, int nrBilete)
        {
            try
            {
                spectacoleDAL.updateSpectacol(titlu, regizor, actori, data, nrBilete);
            }
            catch (Exception e)
            {
                throw e;
            }
         }
        public void deleteSpectacol(String titlu)
        {
            //ca sa nu avem errori din cauza legaturii prin cheie straina
            //=> trebuie sa stergem toate biletele pentru filmul pe care dorim sa il stergem
            try
            {
                Spectacole s = spectacoleDAL.getSpectacol(titlu);
                bileteDAL.deleteBilete(s.Id);
                spectacoleDAL.deleteSpectacol(titlu);
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public DataTable getTabelSpectacole()
        {
            try
            {
                return spectacoleDAL.getTabelSpectacole();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
