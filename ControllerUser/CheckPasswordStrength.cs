using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerUser
{
    public class CheckPasswordStrength
    {

        public enum PasswordStrength
        {
            Inaceitavel,
            Fraca,
            Aceitavel,
            Forte,
            Segura
        }

        /*
        GetPontoPorTamanho -Seis pontos serão atribuídos para cada caractere na senha, até um máximo de sessenta pontos.
        GetPontoPorMinusculas - Cinco pontos serão concedidos se a senha inclui uma letra minúscula. Dez pontos serão atribuídos se mais de uma letra minúscula estiver presente.
        GetPontoPorMaiusculas - Cinco pontos serão concedidos se a senha incluir uma letra maiúscula. Dez pontos serão atribuídos se mais de uma letra maiúscula estiver presente.
        GetPontoPorDigitos - Cinco pontos serão concedidos se a senha incluir um dígito numérico. Dez pontos serão atribuídos se mais de um dígito numérico estiver presente.
        GetPontoPorSimbolos - Cinco pontos serão concedidos se a senha incluir qualquer caractere diferente de uma letra ou um dígito. Isto inclui símbolos e espaços em branco. Dez pontos serão concedidos se houver dois ou mais de tais caracteres.
        GetPontoPorRepeticao - Se houver caracteres repetidos na senha será atribuido 30 pontos que será subtraida da fórmula do cálculo do total dos pontos;
        */

        public int GeneratePasswordPoints (string password)
        {
            if (password == null) return 0;
            int pointsPerSize       = GetPointsPerSize(password);
            int pointsPerLowercase  = GetPointsPerLowercase(password);
            int pointsPerUppercase  = GetPointsPerUppercase(password);
            int pointsPerDigits     = GetPointsPerDigits(password);
            int pointsPerSymbols    = GetPointsPerSymbols(password);
            int pointsPerRepetition = GetPointsRepetition(password);
            return pointsPerSize + pointsPerLowercase + pointsPerUppercase + pointsPerDigits + pointsPerSymbols + pointsPerRepetition;
        }

        private int GetPointsPerSize (string password)
        {
            return Math.Min(10, password.Length) * 7;
        }

        private int GetPointsPerLowercase (string password)
        {
            int rawplacar = password.Length - Regex.Replace(password, "[a-z]", "").Length;
            return Math.Min(2, rawplacar) * 5;
        }

    }
}
