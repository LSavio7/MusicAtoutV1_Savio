
using System;
using System.Windows.Forms;

namespace MusicAtoutV1_Savio
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            ModelProjet.init();
            FConnexion fConnexion = new FConnexion();
            if (fConnexion.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new FMenu());
            }
        }
    }
}
