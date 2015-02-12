using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Class1
    {

        public IEnumerable<int> EjercicioUno()
        {
            int i = 0;
            while(true)
            {
                yield return i++;
            }
        }

        public IEnumerable<int> EjercicioDos()
        {
            int i = 0;
            while (true)
            {
                if (i % 2 == 0)
                {
                    yield return i;
                    
                }
                i++;
                
            }
        }

        public IEnumerable<int> EjercicioTres()
        {
            int i = 0;
            while (true)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    yield return i;
                    
                }
                i++;
            }

        }

        public IEnumerable<string> EjercicioCuatro()
        {
            int i = 0;
            while (true)
            {
                if (i % 3 == 0)
                {
                    yield return "Hola";

                }
                else if (i % 5 == 0)
                {
                    yield return "Mundo";

                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    yield return "HolaMundo";

                }
                else
                {
                    yield return i.ToString();
                }
                
                i++;
            }

        }
    }
}
