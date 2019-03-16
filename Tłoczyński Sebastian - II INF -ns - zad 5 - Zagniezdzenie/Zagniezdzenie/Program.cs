using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zagniezdzenie
{
    class Telewizor
    {

        private int _przekatnaTelewizora = 0;
        private string _firmaTelewizora;
        private string _modelTelewizora;
        private bool _czyPosiadaSmartTV = false;


        private int _czyTelewizorWlaczony = 0;
        private int _czyTelewizorPodlaczony = 0;
        private int _jasnoscTelewizora = 50;
        private int _wyborMenuStatusu = 0;
        public static int _dzwiek = 0;
        
        public void wypisanie()
        {
            Console.WriteLine("Twoj tv:" + _przekatnaTelewizora + _firmaTelewizora + _modelTelewizora + _czyPosiadaSmartTV);
        }

        public Telewizor()
        {
            _przekatnaTelewizora = 40;
            _firmaTelewizora = "Nieznana";
            _modelTelewizora = "Nieznany";
            _czyPosiadaSmartTV = false;
        }

        public Telewizor(int przekatnaTelewizora, string firmaTelewizora, string modelTelewizora, bool czyPosiadaSmartTV)
        {
            _przekatnaTelewizora = przekatnaTelewizora;
            _firmaTelewizora = firmaTelewizora;
            _modelTelewizora = modelTelewizora;
            _czyPosiadaSmartTV = czyPosiadaSmartTV;

        }

        public Telewizor(Telewizor nowyTelewizor)
        {
            _przekatnaTelewizora = nowyTelewizor._przekatnaTelewizora;
            _firmaTelewizora = nowyTelewizor._firmaTelewizora;
            _modelTelewizora = nowyTelewizor._modelTelewizora;
            _czyPosiadaSmartTV = nowyTelewizor._czyPosiadaSmartTV;

        }


        class Glosnik
        {

           
            
           public static void ZmianaGlosnosci (int glosnosc)
            {
                
                if (glosnosc == 7)
                {

                   _dzwiek =_dzwiek + 1;
                    Console.WriteLine("Głośność telewizora została zwiększona o 1");
                }
                else if (glosnosc == 8)
                {
                    if (_dzwiek > 0)
                    {
                        _dzwiek = _dzwiek - 1;
                        Console.WriteLine("Dźwięk został zmniejszonyo o 1");
                    }
                    else
                    {
                        Console.WriteLine("Nie można zmniejszyć głoścności ponieważ już ma wartość 0");
                    }
                }

            }
        }


        private void PodlaczenieTelewizora()
        {
            if(_wyborMenuStatusu == 1)
            {
                _czyTelewizorPodlaczony = 1;
                Console.WriteLine("Telewizor jest podlaczony do pradu");


            }
            else
            {
                _czyTelewizorPodlaczony = 0;
                Console.WriteLine("Telewizor jest odlaczony od pradu");
            }

            
            menuStatus();
        }

        private void WlaczenieTelewizora()
        {
            if(_wyborMenuStatusu == 3)
            {
                if(_czyTelewizorPodlaczony == 1)
                {
                    _czyTelewizorWlaczony = 1;
                    Console.WriteLine("Telewizor został włączony");

                }
                else
                {
                    Console.WriteLine("Telewizor nie został podłaczony do prądu, więc nie można go włączyć. Podłącz go do prądu.");
                }

                
            }
            else
            {
                _czyTelewizorWlaczony = 0;
                Console.WriteLine("Telewizor został wyłączony");
            }

            menuStatus();
        }

        private void ZmianaJasnosci()
        {
            if (_wyborMenuStatusu == 5)
            {
                if (_czyTelewizorPodlaczony == 1)
                {
                    if (_czyTelewizorWlaczony == 1)
                    {
                        _jasnoscTelewizora = _jasnoscTelewizora + 1;
                        Console.WriteLine("Jasność została zwiększona o 1");
                    }
                    else
                    {
                        Console.WriteLine("Nie mozna zmienic jasnosci, ponieważ telewizor jest wyłączony");
                    }
                }
                else
                {
                    Console.WriteLine("Nie mozna zmienic jasnosci, ponieważ telewizor nie jest podłączony do prądu");
                }
            }
            else
            {
                if (_czyTelewizorPodlaczony == 1)
                {
                    if (_czyTelewizorWlaczony == 1)
                    {
                        _jasnoscTelewizora = _jasnoscTelewizora = 1;
                        Console.WriteLine("Jasność została zmniejszona o 1");
                    }
                    else
                    {
                        Console.WriteLine("Nie mozna zmienic jasnosci, ponieważ telewizor jest wyłączony");
                    }
                }
                else
                {
                    Console.WriteLine("Nie mozna zmienic jasnosci, ponieważ telewizor nie jest podłączony do prądu");
                }
            }

            menuStatus();
        }

        

        public void menuStatus()
        {
            Console.WriteLine("Wybierz co chcesz zrobić z telewizorem:");
            Console.WriteLine("1 - Podłącz telewizor do prądu");
            Console.WriteLine("2 - Odłącz telewizor od prądu");
            Console.WriteLine("3 - Włącz telewizor");
            Console.WriteLine("4 - Wyłącz telewizor");
            Console.WriteLine("5 - Zwiększ jasność (domyslnie jest ustawiona na 50%)");
            Console.WriteLine("6 - Zmniejsz jasność (domyslnie jest ustawiona na 50%)");
            Console.WriteLine("7 - Zwiększ głośność");
            Console.WriteLine("8 - Zmniejsz głośność");
            Console.WriteLine("9 - Zakoncz program");
            _wyborMenuStatusu = int.Parse(Console.ReadLine());



            switch (_wyborMenuStatusu)
            {

                case 1:
                    PodlaczenieTelewizora();
                    break;

                case 2:
                    PodlaczenieTelewizora();
                    break;

                case 3:
                    WlaczenieTelewizora();
                    break;

                case 4:
                    WlaczenieTelewizora();
                    break;

                case 5:
                    ZmianaJasnosci();
                    break;

                case 6:
                    ZmianaJasnosci();
                    break;

                case 7:
                    Glosnik.ZmianaGlosnosci(_wyborMenuStatusu);
                    break;

                case 8:
                    Glosnik.ZmianaGlosnosci(_wyborMenuStatusu);
                    break;

                case 9:
                    
                    break;

            }
            
            

        }
        

    }


    class Program
    {
        static void Main(string[] args)
        {

            Telewizor tv1 = new Telewizor();
            Telewizor tv2 = new Telewizor(40,"Toshiba","40Hu0001",true);
            Telewizor tv3 = new Telewizor(tv2);
            
            Telewizor mojTelewizor = new Telewizor();

            mojTelewizor.menuStatus();
            



        }
    }
}
