using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop3
{
    class BasvuruManager
    {
        //Method İnjection
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggers)
        {
            //Başvuran bilgilerini değerlendirme
            krediManager.Hesapla();

            foreach (var logger in loggers)
            {
                logger.Log();

            }

             

        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
