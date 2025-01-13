using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paradigmi.Library.Models.Entities
{
    public class Utenti
    {
        public Utenti() { }
        public Utenti(string Nome, string Cognome, string Email, string Password)
        {
            this.Nome = Nome;
            this.Cognome = Cognome;
            this.Email = Email;
            this.Password = Password;
        }
        public int IdUser { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Cognome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

    }
}
