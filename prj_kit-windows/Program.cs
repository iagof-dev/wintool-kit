///
/// N3rdyDzn.xyz | GitHub.com/N3rdyDzn
/// 
/// Aplicativo desenvolvido apenas para uso próprio...
/// e Disponibilizado em Open Source publicamente
/// caso haja necessidade
///
/// Se possuir uma correção/atualização
/// Faça um fork no projeto :)
/// Obrigado!   

using System;
using System.Net;
using System.Security.Principal;
using System.IO;
using System.Resources;
using System.Text;
using System.Threading;

Console.Title = "Kit Formatação do Windows - github.com/n3rdydzn";
WebClient web = new WebClient();
string logo = web.DownloadString("https://pastebin.com/raw/uvM43pXP");
string resposta = string.Empty;
if (Directory.Exists(Environment.CurrentDirectory + "\\lib"))
{
    Directory.Delete(Environment.CurrentDirectory + "\\lib", true);
    Directory.CreateDirectory(Environment.CurrentDirectory + "\\lib");
}
else
{
    Directory.CreateDirectory(Environment.CurrentDirectory + "\\lib");
}
string download_folder = Environment.CurrentDirectory + "\\lib\\";
Console.WriteLine("Carregado!");

//Funções :)
void key_windows() {
    Console.WriteLine(logo);
    Console.WriteLine("");
    Console.WriteLine("Windows 10 Key Home:");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("TX9XD-98N7V-6WMQ6-BX7FG-H8Q99");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(" ");
    Console.WriteLine("Windows 10 Key Pro:");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("C94GG-V7WDK-FRFXV-JTBBV-MM8HK");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine(" ");
    Console.WriteLine("Pressione qualquer tecla para continuar...");
    Console.ReadKey();
    user_menu();

}
void driver_nvidia() {
    Console.WriteLine(logo);
    Console.WriteLine("");
    Console.WriteLine("Nvidia Drivers | Baixando Drivers...");
    web.DownloadFile("https://us.download.nvidia.com/GFE/GFEClient/3.25.1.27/GeForce_Experience_v3.25.1.27.exe", download_folder + "geforce_experience.exe");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("✓ Baixado!");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Iniciando...");
    System.Diagnostics.Process.Start(download_folder+"geforce_experience.exe");
    Console.WriteLine("Pressione qualquer tecla para continuar...");
    Console.ReadKey();
    user_menu();
}
void driver_amd() {
    Console.WriteLine(logo);
    Console.WriteLine("");
    Console.WriteLine("AMD Drivers | Baixando Drivers...");
    web.DownloadFile("https://drivers.amd.com/drivers/installer/21.50/whql/amd-software-adrenalin-edition-22.5.1-minimalsetup-220509_web.exe", download_folder + "amd_software.exe");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("✓ Baixado!");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Iniciando...");
    System.Diagnostics.Process.Start(download_folder + "amd_software.exe");
    Console.WriteLine("Pressione qualquer tecla para continuar...");
    Console.ReadKey();
    user_menu();
    
}
void driver_intel()
{
    Console.WriteLine(logo);
    Console.WriteLine("");
    Console.WriteLine("INTE Drivers | Baixando Drivers...");
    web.DownloadFile("https://dsadata.intel.com/installer", download_folder + "intel_drivers.exe");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("✓ Baixado!");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Iniciando...");
    System.Diagnostics.Process.Start(download_folder + "intel_drivers.exe");
    Console.WriteLine("Pressione qualquer tecla para continuar...");
    Console.ReadKey();
    user_menu();
}
void softwares()
{
    Console.WriteLine(logo);
    Console.WriteLine("");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Escolha o Software:");
    Console.WriteLine("[1] Uninstall Tool + Ativador");
    Console.WriteLine("[2] 7zip");
    Console.WriteLine("[3] WinAero Tweaker");
    Console.WriteLine("[4] Internet Drivers (Para PCs Antigos)");
    Console.WriteLine(" ");
    Console.ForegroundColor = ConsoleColor.White;
    string resposta_software = Console.ReadLine();
    switch (resposta_software)
    {
        case "1":
            Console.Clear();
            Console.WriteLine(logo);
            Console.WriteLine("");
            Console.WriteLine("Softwares | Baixando Uninstall Tool...");
            web.DownloadFile("https://cdn.discordapp.com/attachments/889233196091342920/975088090668486717/uninstalltool_setup.exe", download_folder + "uninstall_tool_setup.exe");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("✓ Baixado!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Iniciando...");
            System.Diagnostics.Process.Start(download_folder + "uninstall_tool_setup.exe");
            Console.WriteLine("Softwares | Baixando Uninstall Tool ATIVADOR...");
            web.DownloadFile("https://cdn.discordapp.com/attachments/889233196091342920/975088663593615370/crack.zip", download_folder + "crack.zip");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("✓ Baixado!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Iniciando...");
            //System.Diagnostics.Process.Start(download_folder + "crack.zip");
            Console.WriteLine("Extraia o Zip para o diretorio do Uninstall Tool e Abra");
            break;
        case "2":
            Console.Clear();
            Console.WriteLine(logo);
            Console.WriteLine("");
            Console.WriteLine("Softwares | Baixando 7zip...");
            web.DownloadFile("https://www.7-zip.org/a/7z2107-x64.exe", download_folder + "7zip.exe");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("✓ Baixado!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Iniciando...");
            System.Diagnostics.Process.Start(download_folder + "7zip.exe");
            break;
        case "3":
            Console.Clear();
            Console.WriteLine(logo);
            Console.WriteLine("");
            Console.WriteLine("Softwares | Baixando WinAero Tweaker...");
            web.DownloadFile("https://cdn.discordapp.com/attachments/889233196091342920/975094669463666738/WinaeroTweaker-1.33.0.0-setup.exe", download_folder + "winaerotweaker.exe");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("✓ Baixado!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Iniciando...");
            System.Diagnostics.Process.Start(download_folder + "winaerotweaker.exe");
            break;

        case "4":
            Console.Clear();
            Console.WriteLine(logo);
            Console.WriteLine("");
            Console.WriteLine("Softwares | Baixando 3DP CHIP...");
            web.DownloadFile("https://www.3dpchip.com/new/3DP_Net_v2101.exe", download_folder + "3dpnet_fix.exe");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("✓ Baixado!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Iniciando...");
            System.Diagnostics.Process.Start(download_folder + "3dpnet_fix.exe");
            break;
        default:
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            user_menu();
            break;
    }



 
    user_menu();
}

//interações do usuário

void user_menu(){
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine(logo);
    Console.WriteLine("");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("============================================");
    Console.WriteLine("[1] Drivers (Nvidia)  |   [4] Windows 10 Key");
    Console.WriteLine("[2] Drivers (AMD)     |   [5] Softwares");
    Console.WriteLine("[3] Drivers (Intel)   |   [6] Otimizar");
    Console.WriteLine("============================================");
    Console.WriteLine("");

    Console.ForegroundColor = ConsoleColor.White;
    resposta = Console.ReadLine();
    Console.Clear();
    switch (resposta)
    {
        case "1":
            driver_nvidia();
            break;
        case "2":
            driver_amd();
            break;
        case "3":
            driver_intel();
            break;
        case "4":
            key_windows();
            break;
        case "5":
            softwares();
            break;
        case "6":

            break;
        default:
            Console.WriteLine("Opção Invalida!");
            Console.ReadKey();
            Environment.Exit(0);
            break;
    }
}


//loader
user_menu();


Console.ReadKey();