using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCource.MainConstructions2
{
    public enum ЕnumТуре
    {
        Manager=26,
        Grunt=56,
        Contractor=456,
        VicePresident
    }

    public static class Enums
    {
        public static void Show()
        {
            var en = ЕnumТуре.Contractor;

            switch (en)
            {
                case 0:
                    break;

                default:
                    throw new NotImplementedException();
            }

            Console.WriteLine(en);
        }
    }
}
