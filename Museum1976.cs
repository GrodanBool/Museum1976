using System;

namespace C__Intro
{
    class Program
    {
        static void Main()
        {
            string input;
            int rumsnummer = 0;

            System.Console.WriteLine("Välkommen till museet, du är nu i Entrén \n ");

            while (rumsnummer == 0)
            {
                do
                {

                    System.Console.WriteLine("Vart vill du gå? in i museet eller lämna museet? \n ");
                    System.Console.WriteLine("Du kan också gå direkt till ett specifikt rum mellan 1 och 6 genom att skriva rumsnummret. \n");
                    System.Console.WriteLine("Om du vill se en karta över museet, skriv: ´´karta´´\n");
                    input = Console.ReadLine();

                    int listNumber;

                    bool success = int.TryParse(input, out listNumber);

                    if (input.ToLower() == "q" || input.ToLower() == "lämna" || input.ToLower() == "lämna museet" || input.ToLower() == "l")
                    {
                        System.Console.WriteLine("Du lämnar nu museet, välkommen åter!“\n");
                        Environment.Exit(0);
                    }

                    else if (listNumber >= 1)
                    {
                        switch (listNumber)
                        {
                            case 1:
                                System.Console.WriteLine("Du går nu till rum 1!\n");
                                rumsnummer = 1;
                                break;

                            case 2:
                                System.Console.WriteLine("Du går nu till rum 2!\n");
                                rumsnummer = 2;
                                break;

                            case 3:
                                System.Console.WriteLine("Du går nu till rum 3!\n");
                                rumsnummer = 3;
                                break;

                            case 4:
                                System.Console.WriteLine("Du går nu till rum 4!\n");
                                rumsnummer = 4;
                                break;

                            case 5:
                                System.Console.WriteLine("Du går nu till rum 5!\n");
                                rumsnummer = 5;
                                break;

                            case 6:
                                System.Console.WriteLine("Du går nu till rum 6!\n");
                                rumsnummer = 6;
                                break;

                            default:
                                System.Console.WriteLine("Ogiltit svar");
                                break;
                        }



                    }

                    else if (input.ToLower() == "in" || input.ToLower() == "in i museet" || input.ToLower() == "i" || input.ToLower() == "gå")
                    {
                        System.Console.WriteLine("Du lämnar nu Entrén och kommer in i museets första rum med Salvador Dali \n ");
                        rumsnummer = 1;
                    }

                    else if (input.ToLower() == "karta")
                    {
                        System.Console.WriteLine(" ███╗   ███╗██╗   ██╗███████╗███████╗██╗   ██╗███╗   ███╗");
                        System.Console.WriteLine(" ████╗ ████║██║   ██║██╔════╝██╔════╝██║   ██║████╗ ████║");
                        System.Console.WriteLine(" ██╔████╔██║██║   ██║███████╗█████╗  ██║   ██║██╔████╔██║");
                        System.Console.WriteLine(" ██║╚██╔╝██║██║   ██║╚════██║██╔══╝  ██║   ██║██║╚██╔╝██║");
                        System.Console.WriteLine(" ██║ ╚═╝ ██║╚██████╔╝███████║███████╗╚██████╔╝██║ ╚═╝ ██║");
                        System.Console.WriteLine(" ╚═╝     ╚═╝ ╚═════╝ ╚══════╝╚══════╝ ╚═════╝ ╚═╝     ╚═╝");
                        System.Console.WriteLine("        .-----------------------------------------.");
                        System.Console.WriteLine("        |             |             |             |");
                        System.Console.WriteLine("        |             |             |             |");
                        System.Console.WriteLine("        |                                         |");
                        System.Console.WriteLine("        |     Rum 3         Rum 4         Rum 5   |");
                        System.Console.WriteLine("        |             |             |             |");
                        System.Console.WriteLine("        |             |             |             |");
                        System.Console.WriteLine("        |____     ____|_____________|____     ____|");
                        System.Console.WriteLine("        |             |             |             |");
                        System.Console.WriteLine("        |             |             |             |");
                        System.Console.WriteLine("        |                                         |");
                        System.Console.WriteLine("        |    Rum 2          Rum 1        Rum 6    |");
                        System.Console.WriteLine("        |             |             |             |");
                        System.Console.WriteLine("        |             |             |             |");
                        System.Console.WriteLine("        |_____________|____     ____|_____________|");
                        System.Console.WriteLine("                      |             |");
                        System.Console.WriteLine("                      |    Entré    |");
                        System.Console.WriteLine("                      |             |");
                        System.Console.WriteLine("                      |_____    ____|\n\n");
                    }

                    else
                    {
                        System.Console.WriteLine("Ogiltit svar");

                    }
                } while (rumsnummer == 0);

                while (rumsnummer >= 1 && rumsnummer <= 6)

                    do
                    {

                        int rumpres = rumsnummer;
                        switch (rumpres)
                        {
                            case 1:
                                System.Console.WriteLine("Välkommen till det första rummet i utställningen, här visas Salvador Dalis La persistencia de la memoria\n");
                                System.Console.WriteLine("      ;!>,!!!>");
                                System.Console.WriteLine("      <! ;!!!`");
                                System.Console.WriteLine("      !! `!!!.");
                                System.Console.WriteLine("      !!',!!!>");
                                System.Console.WriteLine("      !! !!!!!");
                                System.Console.WriteLine("     ;!! !!!!!");
                                System.Console.WriteLine("     `!! !!!!!");
                                System.Console.WriteLine("      !! !!!!!>                           .");
                                System.Console.WriteLine("      `!.`!!!!!                        ;<!`");
                                System.Console.WriteLine("       !! `!!!!                     ,<!'`");
                                System.Console.WriteLine("       `!> !!!!                   ;<!`");
                                System.Console.WriteLine("      <!! !!!!>                ;!'`");
                                System.Console.WriteLine("       !!! `!!!!               !!`                                    ,c,");
                                System.Console.WriteLine("       !!!> !!!!>             ;`<             ,cc$$cc           .,r== $$c !");
                                System.Console.WriteLine("        !!!! !!!!!!.        ,<!' !!!!!>>>;;;;;;;;.`´?$$c MMMMMMM )MM ,= $$.`");
                                System.Console.WriteLine("       <!!> !!!!!!!!!!!!!>'' ,>''''   ``````''''!!!; ?$$c`MMMMMM.`MMMP== `$h");
                                System.Console.WriteLine("       `!! ;!!!!!!''''.,;;;'''          JF !;;;,,,,; 3$$.`MMMMMb MMMnnnM $$h");
                                System.Console.WriteLine("       ;!! <!!!!.;;!!!''`               JF.!!!!!!!!!>`$$h `MMMMM MMMMMMM $$$");
                                System.Console.WriteLine("       ;!!>`!!!!!!'`                    ?> !!!!!!!!!> $$$  MMMMM MMMMMMM $$$");
                                System.Console.WriteLine("       <!! ;!!!!'                       `h !!!!!!!!!! $$$ MMMMMM MMMM´ M $$$");
                                System.Console.WriteLine("       `!>'!!!!                          b !!!!!!!!!! $$$ MMMMMM MMML,,`,$$$");
                                System.Console.WriteLine(",,,,,, ;! <!!!> ,,,,,,,,,,,,,,,,         $ !!!!!!!!!! $$$ MMMMMM MMMMML J$$F");
                                System.Console.WriteLine("!!!!!! !! !!!! `!!!!!!!!!!!!!!' ;        $ !!!!!!!!!! $$$ MMMMMP.MMMMMP $$$F");
                                System.Console.WriteLine("!!!!! ;!! !!!!> !!!!!!!!!!!!' ;' .`.`.`. ?.`!!!!!!!!! 3$$  MMMP `MMMMM>,$$P ");
                                System.Console.WriteLine("!!!!' !!' !!!!> !!!!!!!!!!' ;!' `.`.`.`. `h !!!!!!!!! $$$  MMML  MMPPP J$$'.");
                                System.Console.WriteLine("!!! !!!;!!!!!';!!!!!!!!' ;!'  .`.`.`.`.` ?,`!!!!!!!! ?$$ MMMMM.,MM_´',$$F . ");
                                System.Console.WriteLine("!!!';!!!.!!!!' <!!!!!!!` ;'  .`.`.`.`.`.`. ? `!!!!!!!>`$$ MMMMMbdML ` $$$  .");
                                System.Console.WriteLine("``` !!!> !!!! ```````` ;!  .`.`.`.`.`.`.`.` h `!!!!!!> $$ IMMMMMMMMM d$$' `.");
                                System.Console.WriteLine("!!' !!!''!!! <!!!!!!!> ' .`.`.`.`.`.`.`.`.` `?,`'!!!!! ?$h 4MMMMMMP z$$' .`.");
                                System.Console.WriteLine("'' <!!! !!!> ''''''''  .`.`.`.`.`.`.`.`.`.`.` ?h.``'`..`$$  MMMMMM ,$$F `.`.");
                                System.Console.WriteLine("` !!!! <!!!.`.`.`.`.`.`.`.`.`.`.`.`.`.`.`.`.`. `´??$F´. `$h.`MMMMM $$$'.`.`.");
                                System.Console.WriteLine(" <!'! .!!!!> .`.`.`.`.`.`.`.`.`.`.`.`.`.`.`.`.`.`. cccc  `$$.'4MMP.3$F .`.`.");
                                System.Console.WriteLine("<!''! !!!!!> .`.`.`.`.`.`.`.`.`.`.`.`.`.`.`.`.`. J$$$$$F . ´$h.´ . 3$h .`.`.");
                                System.Console.WriteLine("!' ! !!!!!!> .`.`.`.`.`.`.`.`.`.`.`.`.`.`.`.`.`.  ´´´´ .`.`.`$$, 4 3$$ .`.`.");
                                System.Console.WriteLine(" ;! !!!!!!! `.`.`.`.`.`.`.`.`.`.`.`.`.`.`.`.`.`.`.`.`.`.`.`.  ?$h  J$F .`.`.");
                                System.Console.WriteLine(";'  !!!!!!! `.`.`.`.`.`.`.`.`.`.`.`.`.`.`.`.`.`.`.`.`.`.`.`.`. ´$$$$P' .`.`.");
                                System.Console.WriteLine("'  <!!!!!!! `.`.`.`.`.`.`.`.`.`.`.`.`.`.`.`.`.`.`.`.`.`.`.`.`.`. . .`.`.`.`.");
                                System.Console.WriteLine(",' !!!!!!! .`.`.`.`.`.`.`.`.`.`.`.`.`.`.`.`.`.`.`.`.`.`.`.`.`.`.`.`.`.`.`.`.");
                                System.Console.WriteLine("!! !!!!!!',,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,  `.`.`.`.");
                                System.Console.WriteLine("!! !!!!!! !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!'  `.`.`.`.");
                                System.Console.WriteLine("!! <!!!!';!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! ;! `.`.`.`.");
                                System.Console.WriteLine("!! ;!!!!>`!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!' <!! `.`.`.`.");
                                System.Console.WriteLine("',,!!!!''.;!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!' <!!! `.`.`.`.");
                                System.Console.WriteLine("'''''.,;!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!' <!!!! `.`.`.`.");
                                System.Console.WriteLine(";!!!!!!!!!!!!!!!!!!!!!!!>>>'''''''''`````''''''<!!!!!!!!!!!' !!!!!! `.`.`.`.");
                                System.Console.WriteLine("!!!!!!!!!!!!!!!!!!''''_,,uunmnmnmdddPPPPPPbbbnmnyy,_```''!  !!!!!!! `.`.`.`.");
                                System.Console.WriteLine("!!!!!!!!!''_``!'`,nmMMPP´´´',.,ccccccr==pccccc,,..`´´444n,.`<!!!!!! `.`.`.`.");
                                System.Console.WriteLine("!!!!!!!' ,dMM ,nMMP´´,zcd$h.`$$$$$$$$L c  $$$$$$$$$$??cc`4Mn <!!!!! `.`.`.`.");
                                System.Console.WriteLine("!!!!!! ,MMMP uMMP ,d$$$$$$$$cd$F ??$$$$$cd$$$$$$$$$F, ??h.`Mx !!!!! `.`.`.`.");
                                System.Console.WriteLine("!!!!!! MMMP uMM´,F,c ´.$$$$$$$P'   ?$$$$$$$$$$$$$$$$C',J$$.`M.`!!!! `.`.`.`.");
                                System.Console.WriteLine("!!!'`  MMM 4MMM L`´=-z$$P´.,,.    ,c$$$$$$$$$$$$$$$$$$$$$$$ ML !!!! `.`.`.`.");
                                System.Console.WriteLine("!!!.   `´´ MMMM `$$hc$$$L,c,.,czc$$$$$$$$$$$$$$$$$$$$$$$$$$.4M `!!! `.`.`.`.");
                                System.Console.WriteLine("!!!!;;;..  `MMMb ?$$$$$$??´´´´?????????????????? ;.`$$$$$$$'JM',!!! `.`.`.`.");
                                System.Console.WriteLine("!!!!!!!!!>  4MMMb.´?$$$cc,.. .,,cccccccccccccccc,c`.$$$$$$$ MM <!!! `.`.`.`.");
                                System.Console.WriteLine("!!!!!!!!!!  `MMMMMb,.´??$$$$$$$$$$$$$$$$$$$$$$$$$$ $$$$?$$$ MM ;!!! `.`.`.`.");
                                System.Console.WriteLine("!!!!!!!!!!    ´4MMMMMMmn,.´´´???$$$$$$$$$$$$$$$$$$ $$$´ ?$$ MP !!!! `.`.`.`.");
                                System.Console.WriteLine("!!!!!!!!!!!;.   ´4MMMMMMMMMMMmnmn,.`´´´?????$$$$$$ ?$$  `CF.M> !!!! `.`.`.`.");
                                System.Console.WriteLine("!!!!!!!!!!!!!!;.   `´´44MMMMMMMMMMMMMMMMnnnn. ?$$$.<$$$h.$h MM !!!! `.`.`.`.");
                                System.Console.WriteLine("!!!!!!!!!!!!!!!!>.;.      `´´444MMMMMMMMMMMMMb $$$:<$$$$$$$ 4M <!!! `.`.`.`.");
                                System.Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!;<;I;>;.     ..´´´´44MMMM J$'  <$$$$$$h`Mb`!!! `.`.`.`.");
                                System.Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!>;      `MMM ?$.  d$$$$$$$ MM.`!! `.`.`.`.");
                                System.Console.WriteLine("!!!!!!!!!!'``!''' ..`'<!!!!!!!!!!!!!!!; .  MMM.<$$ <$$$$$$$$ 4Mb !! `.`.`.`.");
                                System.Console.WriteLine("!'''''''''..    ;MMMMnn.'!!!!!!!!!!!!!!! ; MMM J$$hJ$$$$$$$$h`MM !! `.`.`.`.");
                                System.Console.WriteLine(",xmdMMMbnmx,.    MMMMMMMr !!!!!!!!!!!!' ;: MMM $$$$$$$$$$??$$ MM !! `.`.`.`.");
                                System.Console.WriteLine("P´'.,,,,c`´´4MMn  MMMMMMx !!!!!!!!!!!` <!: MMM $$$$$$$$L =c$F.MP !! `.`.`.`.");
                                System.Console.WriteLine("ub ´P4MM´IM,x,´4b,`44MMMP !!!!!!!!!!  !!!: MMM ???$$$$$$´=,$ JM';!! `.`.`.`.");
                                System.Console.WriteLine("ML,,nn4Mx`´MMMx.`ML ;,,,;<!!!!!!!!! ;!!!!: MMM.-=,$$$$$$hc$'.MP !!! `.`.`.`.");
                                System.Console.WriteLine(". MMM   4Mx`MMML MM,`<!!!!!!!!!!!! ;!!!!!' `MMb  d$$$$$$$$' MM',!!! `.`.`.`.");
                                System.Console.WriteLine(",d´ MMn. .,nMMMM MMM '!!!!!!!!!!! ;!!!!!!>  4MMb `$$$$$$$'.dM'.!!!! `.`.`.`.");
                                System.Console.WriteLine(".`´M´_´ MMMMMMMP,MMM ;!>>!!!!!!' <!!!!!!!!!. ´MMb $$$$$$$ dM ;!!!!! `.`.`.`.");
                                System.Console.WriteLine(" 'nr;MMMMM´MMMP dMM' >>!I!I<<!  <!!!!!!!!!!!. `MM.`$$$$$$ MM !!!!!! `.`.`.`.");
                                System.Console.WriteLine(".,Jn,´´. ,uMMP dMMP /)<;>><>' .!!!!!!!!!!!!!!; `Mb $$$$$F;MP !!!!!! `.`.`.`.");
                                System.Console.WriteLine(" dPPM 4MMMMM´ dMMP (->;)<><' ;!!!!!!!!!!!!!!!!. 4M $$$$$h M>.!!!!!! `.`.`.`.");
                                System.Console.WriteLine("=M uMMnMMM´ uMMM´ <!;/;->;' ;!!!!!!!!!!!!!!!!!; 4M.??´$$',M <!!!!!! `.`.`.`.");
                                System.Console.WriteLine("JM IMMMM´ uMMMM',!>;`(>!>' <!!!!!!!!!!!!!!!!!!! 4M> -??',M' !!!!!!! `.`.`.`.");
                                System.Console.WriteLine("MM `MP´ xdMMMP <(;<:)!`)' <!!!!!!!!!!!!!!!!!!!! MMb  - ,M';!!!!!!!' `.`.`.`.");
                                System.Console.WriteLine("MP   ,nMMMMP´ (>:)/;<:!  !!!!!!!!!!!!!!!!!!!!!! `MM.-= d';!!!!!!!! .`.`.`.`.");
                                System.Console.WriteLine(",xndMMMMP´ .;)`;:`>(;:  !!!!!!!!!!!!!!!!!!!!!!!; 4MMnndM <!!!!!!!  .`.`.`.`.");
                                System.Console.WriteLine("MMMMMP´ .;I:`-;I.><I' ;!!!!!!!!!!!!!!!!!!!!!!!!!, 4MMMMP !!!!!!!> `.`.`.`.`.");
                                System.Console.WriteLine("P´´ .,;<I:I;/I\'>-)' ;!!!!!!!!!!!!!!!!!!!!!!!!!!!>.`´P´ <!!!!!!! .`.`.`.`.`.");
                                System.Console.WriteLine(",<;I,<-:><;,<- >;>' ;!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!;;<!!!!!!!!  .`.`.`.`.`.");
                                System.Console.WriteLine("I-/;`<:<;/->:I';(' ;!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!' `.`.`.`.`.`.");
                                System.Console.WriteLine(":/;`<I.:>-;I;<>:  <!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! .`.`.`.`.`.`.");
                                System.Console.WriteLine("I.;>:´<;:<;-/I/  <!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!  .`.`.`.`.`.`.");
                                System.Console.WriteLine(";-;:>:.;`;I';' ;!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!´ `.`.`.`.`.`.´.");
                                break;

                            case 2:
                                System.Console.WriteLine("Välkommen till det andra rummet i utställningen, här visas Leonardo Da Vincis Le proporzioni del corpo umano secondo Vitruvio\n");
                                System.Console.WriteLine("   ,-.");
                                System.Console.WriteLine(" _('_')_");
                                System.Console.WriteLine("(_     _)");
                                System.Console.WriteLine("  /   \\");
                                System.Console.WriteLine(" (_/ \\_)\n");
                                break;

                            case 3:
                                System.Console.WriteLine("Välkommen till det tredje rummet i utställningen, här visas Leonardo Da Vincis L'Ultima Cena\n");
                                System.Console.WriteLine("    _____  ____   ______      ______");
                                System.Console.WriteLine("    \\~~~/ /~~~~\\ /   __|     /   __|");
                                System.Console.WriteLine("      | | |  o  / \\  /  _  _  \\  /");
                                System.Console.WriteLine(" |~|  | | | /~~~   \\ \\  || ||  \\ \\");
                                System.Console.WriteLine(" \\ \\_/  / | |___    \\ \\ ||_||   \\ \\");
                                System.Console.WriteLine("  \\____/  |_____||\\__| ||___||\\__| |");
                                System.Console.WriteLine("                  \\____/      \\____/\n");
                                break;

                            case 4:
                                System.Console.WriteLine("Välkommen till det fjärde rummet i utställningen, här visas Michaelangelos David\n");
                                System.Console.WriteLine("                                              **   **");
                                System.Console.WriteLine("                                         **************  *****");
                                System.Console.WriteLine("                                      **$$$$  ****   $$*******");
                                System.Console.WriteLine("                                    * $$$$$$$$$   $$* **   *$**");
                                System.Console.WriteLine("                                   *  $    $$$$$* $* *$$$$$$$$$**");
                                System.Console.WriteLine("                                  *  $$$$$$$$$$$$$ $$$$$$$$$**$$*");
                                System.Console.WriteLine("                                  $$  $$$$$$$ $$$$$$$$ $$$$$$$$$$$$");
                                System.Console.WriteLine("                                *$ *$$$$$$$$$$$*$*$*$    *****$***");
                                System.Console.WriteLine("                              **$$ $$$$$$*$ **    [[[[[[[   [[[");
                                System.Console.WriteLine("                              **$**$$**$$$@@     [  #####  ## #");
                                System.Console.WriteLine("                            *$$$*****$$$$$$         ..###   ###");
                                System.Console.WriteLine("                            **$$$$$$$$ [[$$ ##        +++   ###");
                                System.Console.WriteLine("                             $$$$$$**[[  [[$$    #          ##");
                                System.Console.WriteLine("                               $$$***#[  #     ###      #   ##");
                                System.Console.WriteLine("                               $$$$$$ ##++ #+        ## ######");
                                System.Console.WriteLine("                               $$$$$#  ###       ##       ##");
                                System.Console.WriteLine("                               $$$$$#   ##            ######");
                                System.Console.WriteLine("                                 $$$### ##      ##    #####");
                                System.Console.WriteLine("                                   $#$ #  +##  #   ##  ## #");
                                System.Console.WriteLine("                                   $$$$     #   +++#######");
                                System.Console.WriteLine("                                   $$*      ##############");
                                System.Console.WriteLine("                                   *$$# #  ++     ++++        ######");
                                System.Console.WriteLine("                                   $$###         ++###      ##      ++");
                                System.Console.WriteLine("                                   $# +#      #######+     +##+   ## ##");
                                System.Console.WriteLine("                                   *#+ ##     ++###+###    +  ###+     ##");
                                System.Console.WriteLine("                                   ## ##+#  # ++ +++++##  +  #++##       ##");
                                System.Console.WriteLine("                                  ##+#  ##  ++##+     ###++ ##++           #");
                                System.Console.WriteLine("                                 ##+ +   ++  +##+  +   +######## #          #");
                                System.Console.WriteLine("                               ###+     ++++##          ++ # # ##+         ##");
                                System.Console.WriteLine("                           ####  +        ++            +++++# ## ##+        #");
                                System.Console.WriteLine("                      ###++   +                           ##############+ +##+##");
                                System.Console.WriteLine("                    ##+       ##                         ++#+ ++#########++##  ");
                                System.Console.WriteLine("                  ####+                                    +#+ +++###############");
                                System.Console.WriteLine("               ###                                       ++++++#+++++##########");
                                System.Console.WriteLine("              ##+                                            ++ +     ####+++++");
                                System.Console.WriteLine("             ##                              ++               +++        ##  ++");
                                System.Console.WriteLine("             ##+                  ++                         +++++ +  # # ##+++");
                                System.Console.WriteLine("             #      ++  +           ++                       ++@++ ++##### # ++");
                                System.Console.WriteLine("             #    +   ####+                                +++++++###++####+##");
                                System.Console.WriteLine("             #    +   ####+                                +++++++###++####+##");
                                System.Console.WriteLine("             #   +    ###++                               +++++######## #######");
                                System.Console.WriteLine("             #  +++    ####++++@                          +++++++++###   ###  #");
                                System.Console.WriteLine("             #+ #+      ###++++++++                            ++++++#   ##+++#");
                                System.Console.WriteLine("             ##+ +      #### #####++++                          ++++##    ###++");
                                System.Console.WriteLine("             ##++      ###########++                          ++++++#      ## +");
                                System.Console.WriteLine("             ###+      ##########+++                             #++#        ##");
                                System.Console.WriteLine("             #+  +    +########++                         ++##########     ");
                                System.Console.WriteLine("            ###+        # ###+++++                         +++++#####      ");
                                System.Console.WriteLine("           ###+  +      #  ##+++                          +++++#######     ");
                                System.Console.WriteLine("           ##++##+     ##   ##++  ##                       ###########     ");
                                System.Console.WriteLine("            ##+##+     ###  ######              #####     ###++++#####");
                                System.Console.WriteLine("            ##  ##     ##      ##  ######  ++              #+  ######");
                                System.Console.WriteLine("            ##+#       ##      ##  ######+++++             ++ #######");
                                System.Console.WriteLine("           ### #+    ###       ##  ########                  ## ####");
                                System.Console.WriteLine("           ######+    ##       ##++    ##+                  ## ## ##");
                                System.Console.WriteLine("          +###  ####+##       ##                            +     #+");
                                System.Console.WriteLine("          ##++ +  ######      ##                                  ##");
                                System.Console.WriteLine("          +##       ++ #     +#                 @@@                #");
                                System.Console.WriteLine("          +#         + #    ##                                    ##");
                                System.Console.WriteLine("          ## +       # #    #                                      #+");
                                System.Console.WriteLine("          ##+        # #    # +                                    #+");
                                System.Console.WriteLine("          ##+        # #    ## ###                                ###");
                                System.Console.WriteLine("          ##+  +     ###    ##    ####                            +##");
                                System.Console.WriteLine("          #++     #  ##+   +#  ########                          ####");
                                System.Console.WriteLine("         ##++        ##    ## ++   ####                         #####");
                                System.Console.WriteLine("          ##++       ++    #         +##         ##            ######");
                                System.Console.WriteLine("         +# +        +#   +#           +#+      #####         ######+");
                                System.Console.WriteLine("          # +       +#    #           +#+   ############           +##");
                                System.Console.WriteLine("          # +      ##    +#           +###+  ######### +###++      +#");
                                System.Console.WriteLine("           ##++  + #     #     #             ###   #  #######++     #");
                                System.Console.WriteLine("           ##++  + #     ##             +### #+#  #+####        #");
                                System.Console.WriteLine("           ##+    +##    ##     ##         +###++#   #++####        #");
                                System.Console.WriteLine("           # + +  +#     #                 +#+++# #+++###+         #");
                                System.Console.WriteLine("            #      #     # +++++           +#+++# #+++###++        ##");
                                System.Console.WriteLine("           +#      #     #    #####+        +#+++# #+++####++        #");
                                System.Console.WriteLine("           # ##    ###   ###++           ++##+++# #+++####          #");
                                System.Console.WriteLine("           ########  ##  ###              ###++## ##++##             #");
                                System.Console.WriteLine("             ### ##     ## ##                ###########               #");
                                System.Console.WriteLine("            ##+ ###      #####              #########                 #");
                                System.Console.WriteLine("             ##### ###     ##+               ## ## ###                 +");
                                System.Console.WriteLine("             ########## #  ##++             +++###++++                 +");
                                System.Console.WriteLine("             ########## #  #++              ++##### ++++                ++");
                                System.Console.WriteLine("             ++## ++  ++  ## #+               ++### #++++               +");
                                System.Console.WriteLine("               ########### ## #+            ++++##+++++++                +");
                                System.Console.WriteLine("                 ##+++  #  #### ++           ++### #+++++++              ++");
                                System.Console.WriteLine("                   #+####    ##++          +++##+ #####++ +             ++");
                                System.Console.WriteLine("                    ##### + + ### ++++      ++###  #####++ +            ++");
                                System.Console.WriteLine("                      ########### #++++    ++###  #####++ +             +");
                                System.Console.WriteLine("                       +###+ ##### ++ ++ +   +#      +# #++  +            +");
                                System.Console.WriteLine("                             ##############  ##       +### ++            ++");
                                System.Console.WriteLine("                              ####+++++###+  ##         ## ++           +++");
                                System.Console.WriteLine("                              #####+++#####  ##          ##+#            ++");
                                System.Console.WriteLine("                              ########+###++  #           ###             +");
                                System.Console.WriteLine("                               ###### # ## #  #           ##++            +");
                                System.Console.WriteLine("                                ## ## ## ## ## #           # # ##         +");
                                System.Console.WriteLine("                                ####  #  ++ # ##           +#  #+         +");
                                System.Console.WriteLine("                                ## ++       # ##            #####         ++");
                                System.Console.WriteLine("                                ######  #   +###             ####+         +");
                                System.Console.WriteLine("                                # ####      ####             #####+         +");
                                System.Console.WriteLine("                                 +#+ ## +#### ##               ####+++  +     #");
                                System.Console.WriteLine("                                   ##  #  #######               ###### ###   ##");
                                System.Console.WriteLine("                                  #    ##  #  ###                 ######+++   ##");
                                System.Console.WriteLine("                                 #########  #####                 ######+++   #");
                                System.Console.WriteLine("                                 ## # # ## # # #                   ## # #  ");
                                System.Console.WriteLine("                                  ##  # +  #  ##                    +## + + +");
                                System.Console.WriteLine("                                 # ###   #     #                     # ### #");
                                System.Console.WriteLine("                                 #  ###+++     #+                    ## ++  #");
                                System.Console.WriteLine("                                 ## #####      ##                    ## ## ####");
                                System.Console.WriteLine("                                 # ######       #                    ## # +  +");
                                System.Console.WriteLine("                                 # + + +#       #                     # + + + +");
                                System.Console.WriteLine("                                  # +  ##       #                     # + + + +");
                                System.Console.WriteLine("                                   #+ ++##     ##                      # # #+ +");
                                System.Console.WriteLine("                                    #+ + +     +#                      ### # +");
                                System.Console.WriteLine("                                    # + + +      #                      +# + +");
                                System.Console.WriteLine("                                    # + +  +     #                       ### ##");
                                System.Console.WriteLine("                                     # ###++     ##                        ## #");
                                System.Console.WriteLine("                                       #  #      ##                        ####");
                                System.Console.WriteLine("                                        # #      #+                         ###");
                                System.Console.WriteLine("                                         ## #   ###                          ##");
                                System.Console.WriteLine("                                          ## #   ##                          ##");
                                System.Console.WriteLine("                                           ### ## #");
                                System.Console.WriteLine("                                           +##  +##");
                                System.Console.WriteLine("                                            ##    #");
                                System.Console.WriteLine("                                            +#    #");
                                System.Console.WriteLine("                                            +#++   ");
                                System.Console.WriteLine("                                             ## +   #");
                                System.Console.WriteLine("                                             ##+     ##");
                                System.Console.WriteLine("                                             # #     +#");
                                System.Console.WriteLine("                                            #+      ###");
                                System.Console.WriteLine("                                             +# +    ++#");
                                System.Console.WriteLine("                                             ##   +   +#");
                                System.Console.WriteLine("                                            ## +     +##");
                                System.Console.WriteLine("                                           ###       #+#");
                                System.Console.WriteLine("                                          #+         + #");
                                System.Console.WriteLine("                                        ##           +##");
                                System.Console.WriteLine("                                        #+ # # # +#    #");
                                System.Console.WriteLine("                                         ##+ #  # #   ##");
                                System.Console.WriteLine("                                          #+##+#  ####\n");
                                break;

                            case 5:
                                System.Console.WriteLine("Välkommen till det femte rummet i utställningen, här visas Raphaels Scuola di Atene\n");
                                System.Console.WriteLine("   ___I_");
                                System.Console.WriteLine("  /\\-_--\\");
                                System.Console.WriteLine(" /  \\_-__\\");
                                System.Console.WriteLine(" |[]| [] |\n");
                                break;

                            case 6:
                                System.Console.WriteLine("Välkommen till det sjätte rummet i utställningen, här visas Donatellos Lo Zuccone\n");
                                System.Console.WriteLine("          ___");
                                System.Console.WriteLine("         / ,_\\    _____");
                                System.Console.WriteLine("        /  _)/   /o    \\");
                                System.Console.WriteLine("        |  \\    /_ `    \\__________");
                                System.Console.WriteLine("        |   \\____ >__,_  \\         |");
                                System.Console.WriteLine("        |                  ____,   |");
                                System.Console.WriteLine("        \\,___________     |    \\   |");
                                System.Console.WriteLine("                   \\      (     \\  |__");
                                System.Console.WriteLine("                    \\    \\ \\     \\   _)_");
                                System.Console.WriteLine("           __________\\/     \\     \\____/");
                                System.Console.WriteLine("          |                ) \\");
                                System.Console.WriteLine("          |     _________ ,   |");
                                System.Console.WriteLine("          |    /       |      /");
                                System.Console.WriteLine("          |   /        |     /");
                                System.Console.WriteLine("          |  /_        |    / ");
                                System.Console.WriteLine("          |    )       |    \\  ");
                                System.Console.WriteLine("          \\   /        |    /  ");
                                System.Console.WriteLine("          |  /         |   /   ");
                                System.Console.WriteLine("          /_/          |  (_   ");
                                System.Console.WriteLine("                       |    )  ");
                                System.Console.WriteLine("                       \\   /  ");
                                System.Console.WriteLine("                       |  / \n");
                                break;

                        }

                        System.Console.WriteLine("Gå till nästa eller föregående rum. För att lämna museet gå till entrén. För att gå till entrén skriv entré\n");
                        input = Console.ReadLine();

                        if (input.ToLower() == "e" || input.ToLower() == "entre" || input.ToLower() == "entré")
                        {
                            System.Console.WriteLine("Går tillbaka till entréen\n");
                            rumsnummer = 0;

                        }

                        else if (input.ToLower() == "n" || input.ToLower() == "fram" || input.ToLower() == "nästa" || input.ToLower() == "gå vidare" || input.ToLower() == "gå")
                        {
                            if (rumsnummer == 6)
                            {
                                System.Console.WriteLine("Du går nu tillbaka till första rummet i utställningen!\n Du har nu sett alla rum i utställningen, men du får gärna gå fler varv! \n");
                                rumsnummer = 1;
                            }

                            else
                            {
                                rumsnummer++;
                            }
                        }

                        else if (input.ToLower() == "föregående" || input.ToLower() == "tillbaka" || input.ToLower() == "t" || input.ToLower() == "f")
                        {
                            if (rumsnummer == 1)
                            {
                                System.Console.WriteLine("Du går nu baklänges till sjätte rummet i utställningen!\n Det är helt OK att gå den vägen också!");
                                rumsnummer = 6;
                            }
                            else
                            {
                                rumsnummer--;
                            }
                        }

                        else
                        {
                            System.Console.WriteLine("Ogiltit svar");

                        }

                    } while (rumsnummer >= 1 && rumsnummer < 6);
            }
        }
    }
}