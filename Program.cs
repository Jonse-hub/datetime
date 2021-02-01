using System;

namespace datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            // opg 1.

            DateTime fødselsdag = new DateTime(2002, 5, 2);
            Console.WriteLine("Min Fødselsdag: "+fødselsdag);
            DateTime Magrethe = new DateTime(1940, 4, 16);
            Console.WriteLine("Dronning Margrethe II Fødselsdag: "+Magrethe);
            DateTime Grundlov = new DateTime(1949, 7, 5);
            Console.WriteLine("første grundlov blev udskrevet: "+Grundlov);
            DateTime håndboldVM = new DateTime(2019, 1, 10);
            Console.WriteLine("første håndboldVM var: "+håndboldVM);                        
            DateTime sommerferie = new DateTime(2020, 7, 6);
            Console.WriteLine("sommerferie 2020 var: "+sommerferie);

            // opg 2.

            Console.WriteLine("\nToLongDateString");
            Console.WriteLine(fødselsdag.ToLongDateString());
            Console.WriteLine(Magrethe.ToLongDateString());
            Console.WriteLine(Grundlov.ToLongDateString());
            Console.WriteLine(håndboldVM.ToLongDateString());
            Console.WriteLine(sommerferie.ToLongDateString());

            Console.WriteLine("\nToShortDateString");
            Console.WriteLine(fødselsdag.ToShortDateString());
            Console.WriteLine(Magrethe.ToShortDateString());
            Console.WriteLine(Grundlov.ToShortDateString());
            Console.WriteLine(håndboldVM.ToShortDateString());
            Console.WriteLine(sommerferie.ToShortDateString());

            Console.WriteLine("\nToString");
            Console.WriteLine(fødselsdag.ToString());
            Console.WriteLine(Magrethe.ToString());
            Console.WriteLine(Grundlov.ToString());
            Console.WriteLine(håndboldVM.ToString());
            Console.WriteLine(sommerferie.ToString());

            // opg 3.

            DateTime nutiden = DateTime.Now;
            DateTime FredagSocial = new DateTime(2020, 2, 5, 13, 00, 00);
            DateTime mødetid = new DateTime(2020, 1, 25, 9, 01, 16);
            DateTime SidsteTVAvis = new DateTime(2021, 1, 22, 21, 00, 00);

            // opg 4.

            Console.WriteLine("\nToLongDateString");
            Console.WriteLine(nutiden.ToLongDateString());
            Console.WriteLine(FredagSocial.ToLongDateString());
            Console.WriteLine(mødetid.ToLongDateString());
            Console.WriteLine(SidsteTVAvis.ToLongDateString());

            Console.WriteLine("\nToShortDateString");
            Console.WriteLine(nutiden.ToShortDateString());
            Console.WriteLine(FredagSocial.ToShortDateString());
            Console.WriteLine(mødetid.ToShortDateString());
            Console.WriteLine(SidsteTVAvis.ToShortDateString());

            Console.WriteLine("\nToString");
            Console.WriteLine(nutiden.ToString());
            Console.WriteLine(FredagSocial.ToString());
            Console.WriteLine(mødetid.ToString());
            Console.WriteLine(SidsteTVAvis.ToString());

            
            // opg. 5-1

            DateTime fødselsdag5 = DateTime.Parse("2002/5/2");
            Console.WriteLine("Min Fødselsdag: "+fødselsdag);
            DateTime Magrethe5 = DateTime.Parse("1940/4/16");
            Console.WriteLine("Dronning Margrethe II Fødselsdag: "+Magrethe);
            DateTime Grundlov5 = DateTime.Parse("1949/7/5");
            Console.WriteLine("første grundlov blev udskrevet: "+Grundlov);
            DateTime håndboldVM5 = DateTime.Parse("2019/1/10");
            Console.WriteLine("første håndboldVM var: "+håndboldVM);                        
            DateTime sommerferie5 = DateTime.Parse("2020/7/6");
            Console.WriteLine("sommerferie 2020 var: "+sommerferie);

            // opg 5-2.

            Console.WriteLine("\nToLongDateString");
            Console.WriteLine(fødselsdag5.ToLongDateString());
            Console.WriteLine(Magrethe5.ToLongDateString());
            Console.WriteLine(Grundlov5.ToLongDateString());
            Console.WriteLine(håndboldVM5.ToLongDateString());
            Console.WriteLine(sommerferie5.ToLongDateString());

            Console.WriteLine("\nToShortDateString");
            Console.WriteLine(fødselsdag5.ToShortDateString());
            Console.WriteLine(Magrethe5.ToShortDateString());
            Console.WriteLine(Grundlov5.ToShortDateString());
            Console.WriteLine(håndboldVM5.ToShortDateString());
            Console.WriteLine(sommerferie5.ToShortDateString());

            Console.WriteLine("\nToString");
            Console.WriteLine(fødselsdag5.ToString());
            Console.WriteLine(Magrethe5.ToString());
            Console.WriteLine(Grundlov5.ToString());
            Console.WriteLine(håndboldVM5.ToString());
            Console.WriteLine(sommerferie5.ToString());

            // opg 5-3.

            DateTime nutiden5 = DateTime.Now;
            DateTime FredagSocial5 = DateTime.Parse("2020/2/5 13:00:00");
            DateTime mødetid5 = DateTime.Parse("2020/1/2 9:01:00");
            DateTime SidsteTVAvis5 = DateTime.Parse("2021/1/22 21:00:00");

            // opg 5-4.

            Console.WriteLine("\nToLongDateString");
            Console.WriteLine(nutiden5.ToLongDateString());
            Console.WriteLine(FredagSocial5.ToLongDateString());
            Console.WriteLine(mødetid5.ToLongDateString());
            Console.WriteLine(SidsteTVAvis5.ToLongDateString());

            Console.WriteLine("\nToShortDateString");
            Console.WriteLine(nutiden5.ToShortDateString());
            Console.WriteLine(FredagSocial5.ToShortDateString());
            Console.WriteLine(mødetid5.ToShortDateString());
            Console.WriteLine(SidsteTVAvis5.ToShortDateString());

            Console.WriteLine("\nToString");
            Console.WriteLine(nutiden5.ToString());
            Console.WriteLine(FredagSocial5.ToString());
            Console.WriteLine(mødetid5.ToString());
            Console.WriteLine(SidsteTVAvis5.ToString());

            


            // Opg. 2-1
            DateTime nutid = DateTime.Now;
            DateTime idag = DateTime.Today;
            DateTime PcClock = DateTime.UtcNow;

            Console.WriteLine(nutid.ToString());
            Console.WriteLine(idag.ToString());
            Console.WriteLine(PcClock.ToString());

            

            // Opg. 2-2

            DateTime om_et_år = nutid.AddYears(1);

            Console.WriteLine(om_et_år.ToString());


            DateTime minus_to_år = nutid.AddYears(-2);
            Console.WriteLine(minus_to_år.ToString());

            DateTime om_en_måned = nutid.AddDays(30);
            Console.WriteLine(om_en_måned.ToString());

            DateTime minus_17_dage = nutid.AddDays(-17);
            Console.WriteLine(minus_17_dage.ToString());

            DateTime plus_tre_måneder = nutid.AddMonths(3);
            Console.WriteLine(plus_tre_måneder.ToString());

            DateTime minus_syv_måneder = nutid.AddMonths(-7);
            Console.WriteLine(minus_syv_måneder.ToString());

            DateTime plus_23_timer = nutid.AddHours(23);
            Console.WriteLine(plus_23_timer.ToString());

            DateTime plus_11_timer = nutid.AddHours(11);
            Console.WriteLine(plus_11_timer.ToString());

            DateTime plus_23tim_17min = nutid.AddHours(11.17);
            Console.WriteLine(plus_23tim_17min.ToString());


            // opg 2-3
            Console.WriteLine(nutid.ToString());
            Console.WriteLine(nutid.ToShortDateString());
        }
    }
}
