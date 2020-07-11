using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordEntry
{
    public class DataAccess
    {
        public DataAccess()
        {
            fileExistCreate();
            read();
        }

        public List<PasswordDTO> Passwords { get; set; }

        public void Save()
        {
            write();
        }

        private void write()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("Data/Passwords.json"))
                {
                    if (Passwords == null || Passwords.Count == 0)
                        sw.Write("[]");
                    else
                        sw.Write(JsonConvert.SerializeObject(from p in Passwords select new { p.ApplicationCode, p.ApplicationName, p.UserName, p.Password }));
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while writing the record.", ex);
            }
        }

        private void read()
        {
            try
            {
                using (StreamReader sw = new StreamReader("Data/Passwords.json"))
                {
                    Passwords = JsonConvert.DeserializeObject<List<PasswordDTO>>(sw.ReadToEnd());
                    if (Passwords == null)
                        Passwords = new List<PasswordDTO>();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("There was an error reading the record.", ex);
            }
        }

        private void fileExistCreate()
        {
            bool save = false;
            if (!Directory.Exists("Data"))
            {
                Directory.CreateDirectory("Data");
                save = true;
            }

            if (!File.Exists("Data/Passwords.json"))
            {
                using (var file = File.Create("Data/Passwords.json"))
                {
                    save = true;
                    Passwords = new List<PasswordDTO>();
                    file.Close();
                }
            }

            if (save) Save();
        }
    }
}
