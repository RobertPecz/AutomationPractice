using System;
using System.Text;

namespace AutomationPractice
{
    class EmailCreator
    {
        public string TemporaryEmail { get; private set; }

        public void CreateTemporaryEmail()
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            StringBuilder sb = new StringBuilder();
            Random randomAlphabet = new Random();
            for (int i = 0; i < 11; i++)
            {
                if(i != 6)
                {
                    sb.Append(alphabet[randomAlphabet.Next(27)]);
                }
                else
                {
                    sb.Append('@');
                }
            }
            sb.Append(".com");
            TemporaryEmail = sb.ToString();
        }

    }
}
