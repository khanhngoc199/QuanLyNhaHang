using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class userDTO
    {
        private string name;
        private string password;
        private int id, typeUser;
        public userDTO(string Name, string Password, int Id, int TypeUser)
        {
            this.name = Name;
            this.password = Password;
            this.id = Id;
            this.typeUser = TypeUser;

        }
        public userDTO(DataRow row)
        {
            this.name = row["name"].ToString();
            this.password = row["pasword"].ToString();
            this.id = (int)row["id"];
            this.typeUser = (int)row["typeUser"];
        }
        public userDTO()
        {

        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public int Typeuser
        {
            get
            {
                return typeUser;
            }
            set
            {
                typeUser = value;
            }
        }
    }
}
