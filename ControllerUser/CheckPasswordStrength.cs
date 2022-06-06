using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Controller
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

        public static int GeneratePasswordPoints(string password)
        {
            if (password == null) return 0;
            int pointsPerSize       = GetPointsPerSize(password);
            int pointsPerLowercase  = GetPointsPerLowercase(password);
            int pointsPerUppercase  = GetPointsPerUppercase(password);
            int pointsPerDigits     = GetPointsPerDigits(password);
            int pointsPerSymbols    = GetPointsPerSymbols(password);
            int pointsPerRepetition = GetPointsPerRepetition(password);
            return pointsPerSize + pointsPerLowercase + pointsPerUppercase + pointsPerDigits + pointsPerSymbols + pointsPerRepetition;
        }

        private static int GetPointsPerSize(string password)
        {
            return Math.Min(10, password.Length) * 7;
        }

        private static int GetPointsPerLowercase(string password)
        {
            int rawplacar = password.Length - Regex.Replace(password, "[a-z]", "").Length;
            return Math.Min(2, rawplacar) * 5;
        }
        
        private static int GetPointsPerUppercase(string password)
        {
            int rawplacar = password.Length - Regex.Replace(password, "[A-Z]", "").Length;
            return Math.Min(2, rawplacar) * 5;
        }

        private static int GetPointsPerDigits(string password)
        {
            int rawplacar = password.Length - Regex.Replace(password, "[0-9]", "").Length;
            return Math.Min(2, rawplacar) * 6;
        }

        private static int GetPointsPerSymbols(string passwordd)
        {
            int rawplacar = Regex.Replace(passwordd, "[a-zA-z0-9]", "").Length;
            return Math.Min(2, rawplacar) * 5;
        }

        private static int GetPointsPerRepetition(string password)
        {
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"(\w)*.*\1");
            bool repeat = regex.IsMatch(password);
            if (repeat)
            {
                return 30;
            }
            else
            {
                return 0;
            }
        }

        public static bool ValidationCaracters(string password)
        {           
            if ( Regex.IsMatch(password, "[-!#$%&')(*+,./:;<=>?@\\^_`{|}~]") & Regex.IsMatch(password, "[A-Z]") )
            {
                return true;               
            }
            MessageBox.Show(
                "Para sua segurança adicione:" +
                "\n" +
                "\n Letras Maiúsculas: A-Z" +
                "\n Símbolos: !  # $ % & ' ( ) * + , - . / : ; < = > ? @ ^ _` { | } ~ "
                );
            return false;
        }

        public static bool ValidationNumberOfCaracter (string password)
        {
            int QtdCaracter = password.Length;

            if (QtdCaracter >= 6)
            {
                return true;
            }
            MessageBox.Show("A senha deve ter no mínimo 6 caractéres");
            return false;
        }

        public static string GetPasswordStrength(string password)
        {
            int placar = GeneratePasswordPoints(password);

            if (placar < 50)
                return "Inaceitavel";
            else if (placar < 60)
                return "Fraca";
            else if (placar < 80)
                return "Aceitavel";
            else if (placar < 100)
                return "Segura";
            else
                return "Segura";
        }

    }
}
