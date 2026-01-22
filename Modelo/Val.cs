using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Datos
{
    public class Val
    {
        public static void EsEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                throw new Exception("El campo email está vacío");

            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                throw new Exception("El campo email no tiene un formato válido");
        }

        public static void EsContrasenaValida(string contrasena)
        {
            if (string.IsNullOrWhiteSpace(contrasena))
                throw new Exception("El campo contraseña está vacío");

            if (contrasena.Length < 8)
                throw new Exception("El campo contraseña debe tener al menos 8 caracteres");

            if (!Regex.IsMatch(contrasena, @"[A-Za-z]"))
                throw new Exception("El campo contraseña debe contener al menos una letra");

            if (!Regex.IsMatch(contrasena, @"\d"))
                throw new Exception("El campo contraseña debe contener al menos un número");
        }

        public static void EsNumero(string valor, int longitudExacta, string campo)
        {
            if (string.IsNullOrWhiteSpace(valor))
                throw new Exception($"El campo {campo} está vacío");

            if (!Regex.IsMatch(valor, @"^\d+$"))
                throw new Exception($"El campo {campo} debe contener solo números");

            if (valor.Length != longitudExacta)
                throw new Exception($"El campo {campo} debe tener exactamente {longitudExacta} caracteres");

        }
    }

}
