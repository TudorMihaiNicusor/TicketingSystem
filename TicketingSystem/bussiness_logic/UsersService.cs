using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.data_layer;

namespace TicketingSystem.bussiness_logic
{
    class UsersService
    {
        UsersDAL usersDal = new UsersDAL();

        public String login(String username, String password)
        {
            String crypted_password = getMd5Hash(password);
            Users user = usersDal.getUser(username, crypted_password);

            if (user == null)
            {
                throw new Exception();
            }

            return user.Role;

        }
        public Users getUser(String username)
        {
            try
            {
                return usersDal.getUser(username);
            }
            catch (Exception e)
            {
                throw e;
            }
            
        }
        public void deleteUser(String username)
        {
            try
            {
                usersDal.deleteUser(username);
            }
            catch(Exception e)
            {
                throw e;
            }
            
        }
        public void addUser(String username, String password, String role, String name)
        {
            try
            {
                String cryptedPassword = getMd5Hash(password);
                usersDal.addUser(username, cryptedPassword, role, name);
            }
            catch (Exception e)
            {
                throw e;
            }
            
        }
        public void updateUser(String username, String password, String role, String name)
        {
            try
            {
                usersDal.updateUser(username, password, role, name);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static string getMd5Hash(string input)
        {
            MD5 md5Hasher = MD5.Create();
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
    }
}
