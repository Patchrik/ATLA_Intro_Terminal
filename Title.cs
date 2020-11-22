using System;

namespace ATLAprinter
{
  class Title
  {
    public void printASCIIart()
    {
      Console.WriteLine(@"ddxxxxxxxxxkkkkkkkkOkdc;'.';lkKXXXXXNNNK0XWWWWWWWWW0KWWWWMMMMMWWWWWWMWNXNWMWWMWWWWWWWWWWMMMMMWWWWWWWNXK0KXNNNWWWWWWMWWWMMMWWWWWWWWWNNNNXXK0000000OOOkkkkkkkxxxxxxxxxxxdxxdddddddddddddddddoooo
ddxxxxxxxxxkkkkkkkOOl.      ..ckKXXXNNNWWWWWWWWWWWWWWMMWWMMMMMMWWMWWWMMWWWMMMWWMWWWWWWMWMMNK000OOxoc;'...',;;;:loxkO0KNWWMMWWWWWWWWWWNNXXXKKK0000OOOOOkkkkkxxxxxxxxxxxxxxdddddddddddddddddoooo
dxxxxxxxxxkkkkkkkkkd,          'dKXNNNWWWWKO0XNWWWWWMMWWWWMWWMMWX0KNMMMWWMMMWMMWWNNWWWWWWNd,.....                 ...';o0NWMWWWWWWWWWNNXXXXK0koodkOOkxxddooddxxxxxxxxxxxxxddddddddddddddddoooo
xxxxxxxxxxkkkkkkkkd:.           'xXXNNNWWNd..':xKNWWWMWWWWMMWWNx,.'oXWMWWMMWWMW0l;:coOXWWKc                           ,o0NWXOdoloOXNWNNXXXK0o.  .,c:'........',;codxxxxxxxxxddddddddddddddoooo
xxxxxxxxxxkkkkkkko,             .:OXNNNNWXl.   .'lONMWWWMMWMWXd.   .cKWWWMMMMXd'     .c0WNx'                 'codxkxxkKWWNO:.    .c0NNXNNXKd.          ..,;:c:'. .,ldxxxxxxxxddddddddddddddooo
xxxxxxxxkkxkkkkkl.               .oXNNNWWNx.      .dNWWWWMWW0c.     .xWMMWWWKl.       .:0WWKxooodxxc.       'ONWMWWWWWWWXd'        ;ONNNNXKl.        .cdxxkkxo;.  .;dxxxxxxxxxdddddddddddddooo
xxxxxxxxxxkkkkd:.       .'..      'xXNNWWWNo.      .oXWWWWNx,      .lKWWWWNk,.    .    .cKWMWWWWWWWXl.     .lXWMMMWWWWXx;.          :ONNXXKo.       'dOOkxol,.   .:oxxxxxxxxxxxxddddddddddddoo
dxxxxxxxxxkkxl,.       ,dOx;       ,kNWWWWWXd'      .oXWWKl.    .:d0NWMWWXo.   .,dx:.   .cXWWWWWMWMWk'     .dNMMMMWMWO;.      ..     ;OXXXKo.       'llc;..  ..,cdxxxxxxxxxxxxdddddddddddddddo
ddddxxxxxxxo,.        .lkOOo.       ,xKNWWWWNk;      .oKk;.   .:ONWWWWWNO:.   .oKWW0:    .lKWWMMMMMW0:     .xNMMWWWNk,      'o0k,    .c0XXKl.        .   ..;codxxxxxxxxxxxxxxddddddddddddddddd
dxdooool:,..           ...',.        .':dOXNWW0;      .'.    .oK0xooool:.     .lkOxo;.    .c0WMMMMMWKc.    .kWMWWX0o'      ,xXKOc.    .l0X0l.          .:oxkkkkkkkxxxxxxxxxxxxdddddddddddddddd
l:,.....                                 .,cxKNO;           ;kNXl.              ..         .,kNWWWMMKc.    'kWMW0:.        .'''..      .lKXx'          .:dkkkkkkxxxkkxxxxxxxxxxddddddddddddddd
.                                           ,xNWO;         ;0WWNd.              .......      ,kNWWMMK:     'OWMNx.                      ,OXKc.           .,ldxkkkxxkkxxxxxxxxxxxdddddddddddddd
                                           .c0WWNx.      .:0WWMWNOc'      .,cloxkO0K000x;.    :kKWMMXc.    'OWMW0;      ..',,::cc:.     .lXKo.   ':,.      ...;ldxxkxxxxxxxxxxdxdddddddddddddd
.                            ...          .lKWWMW0:     .lKWMWWMWWNd.   .l0XWWWWMMMMMMMMKc.   ,oOWMWNd.    'OWMWk,     'd0XXNNWWWNk'     cKKd.  .l0Oxl,.       ..,;codxxxxxxxxxxxddddddddddddd
l,.               ..',;:clodxkkkd,.       cXWMWWMNx,...,dXWWMMMMMM0,  .;kNWWWWWWMMMWMMWWWKo'.;d0XWWWNx.    ,OWMKc.    .oXWWMMWMMMMNx'    :KKd'  .o0O0Okd;.          ...,:cloodddddddddddddoodd
xdlc,.         .,cdxOO00KKKKXXXXXO:.      :KWMWWMWNX0O0XWMMMMMWWMMKl:lkXWMMMWMWMMWMMWMWWMWNKKXWWWWWMW0l.  .cKWMXo.  .;dKWWWMMWMMMWWNk:...lKXx'.'ck0OOOOOkdl:,.            ......'''''''''''.',
xxxxl.       .;dkOO000000KKKXXXXXXd.      ,OWMWWMMMMWWMMWMMMMMMMMWWWWWMMMMMMMWWMMMMWMMMMMWWWMMMWWMMWWNOc. ,0WWWWN0xx0NWWMMWMMMMMMWWWWX0kOKXXkclk00OO0OOOOOOOkdl;.                           ..
xxxxd;...  .'lxOOkOOOO000KKKKKXXXXKl.     :KWMMWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWWWKl. lNMWMMWMMMMMMMMMMMMWMMMWWWWNNNXXKK0kO00OO0OOOOOOOOkOOkdl:'..                 ...';co
xxxxxxdollldxkkkkkOOOO00000KKKKKXXXKd,..,l0WWMWWWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWXd;cKWMMMMMMMMMMMMMMMMMMMWWWWWWNNXXXXKK00000OOOOOOOOOOOkkkkkkkdolc::::;;;;;;::cccllodddd
xxxxxxkkkkkkkkkkkkOOOOO0000KKKKKKXXXX0O0XNWWWWWWMMMMWWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWWMMMWX0XWMMMWWMMMMMMMWMWWWWWWWWWWWWNXXXKKK0000000O0OOOOOOOOkkkkkkkkkkkkkkkkxxxxxxxxxxddxdddx");
    }
    public void ASCIItext()
    {
      Console.WriteLine(@"
.___________. __    __   _______     __          ___           _______.___________.        ___       __  .______      .______    _______ .__   __.  _______   _______ .______      
|           ||  |  |  | |   ____|   |  |        /   \         /       |           |       /   \     |  | |   _  \     |   _  \  |   ____||  \ |  | |       \ |   ____||   _  \     
`---|  |----`|  |__|  | |  |__      |  |       /  ^  \       |   (----`---|  |----`      /  ^  \    |  | |  |_)  |    |  |_)  | |  |__   |   \|  | |  .--.  ||  |__   |  |_)  |    
    |  |     |   __   | |   __|     |  |      /  /_\  \       \   \       |  |          /  /_\  \   |  | |      /     |   _  <  |   __|  |  . `  | |  |  |  ||   __|  |      /     
    |  |     |  |  |  | |  |____    |  `----./  _____  \  .----)   |      |  |         /  _____  \  |  | |  |\  \----.|  |_)  | |  |____ |  |\   | |  '--'  ||  |____ |  |\  \----.
    |__|     |__|  |__| |_______|   |_______/__/     \__\ |_______/       |__|        /__/     \__\ |__| | _| `._____||______/  |_______||__| \__| |_______/ |_______|| _| `._____|
                                                                                                                                                                                   
");
    }
  }
}
